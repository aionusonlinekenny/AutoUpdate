using Autoupdate.Lib;
using Autoupdate.Properties;
using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace Autoupdate
{
    public partial class FormAutoupdate : Form
    {

        bool mouseDown = false;
        private Point offset;
        bool inProccessing = true;
        Int64 totalFilesSize = 0;
        Int64 totalFilesSizeDl = 0;
        string downloadingFilename = "";
        string shortcutName = "vldoxanh";
        private WebClient webClient;
        XmlNodeList xmlnodes;
        List<XmlNode> filesToDownload;
        int nNodeIndex = 0;
        static readonly string[] fileSpecials = { "Autoupdate.exe", "Interop.IWshRuntimeLibrary.dll", "Autoupdate.ini" };
        static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
        //IniAutoupdate iniAutoupdate;
        //IniConfig iniConfig;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );


        private void ApplicationSetting()
        {
            Settings.Default.CurrentDirectory = Application.StartupPath;
            // this.iniConfig = new IniConfig();

            /*this.iniAutoupdate = new IniAutoupdate();
            Settings.Default.LauncherUrl = this.iniAutoupdate.LauncherLink[1];
           Settings.Default.UpdateUrl = this.iniAutoupdate.UpdateLink[1];
           Settings.Default.AutoupdateFileUrl = this.iniAutoupdate.UpdateLink[1] + @"/" + Settings.Default.AutoupdateFileName;
           Settings.Default.VersionFileUrl = this.iniAutoupdate.UpdateLink[1] + @"/" + this.iniAutoupdate.VersionFile[1];
           Settings.Default.VersionFileName = this.iniAutoupdate.VersionFile[1];
            Settings.Default.GameFile = this.iniAutoupdate.GameFile[1]; */

        }


        public FormAutoupdate()
        {
            InitializeComponent();

            this.ApplicationSetting();

            this.filesToDownload = new List<XmlNode>();
            backgroundWorker1.WorkerReportsProgress = true;
            this.CreateShortcut(this.shortcutName, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Assembly.GetExecutingAssembly().Location);
            this.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.BackColor = Color.Transparent;
            this.mainPanel.BackgroundImage = Resources.bg1;
            this.ApplyRegionFromPng(new Bitmap(Resources.bg1));
            string bakFile = Path.Combine(Settings.Default.CurrentDirectory, "Autoupdate_bak.exe");

            if (System.IO.File.Exists(bakFile))
            {
                System.IO.File.Delete(bakFile);
            }
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // Tls12
        }




        private void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");

            var shell = new WshShell();
            var shortcut = shell.CreateShortcut(shortcutLocation) as IWshShortcut;
            if (shortcut != null)
            {
                shortcut.Description = shortcutName;
                shortcut.TargetPath = targetFileLocation;
                shortcut.WorkingDirectory = Settings.Default.CurrentDirectory;
                shortcut.Save();
            }
        }

        private string FormatSize(Int64 bytes)
        {
            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);
        }

        private void disableButtons(bool status)
        {
            if (status)
            {
                btnQuit.Text = "";

                btnthulai.BackColor = Color.Transparent;
                //btnConfig.BackColor = Color.OldLace;
                btnPlayGame.BackColor = Color.Transparent;
            }
            else
            {
                btnQuit.Text = "";
                Color c = Color.FromArgb(255, 188, 121);
                btnthulai.BackColor = Color.Transparent;
                //btnConfig.BackColor = c;
                btnPlayGame.BackColor = Color.Transparent;
            }

            btnthulai.Enabled = !status;
            //btnConfig.Enabled = !status;
            btnPlayGame.BackColor = Color.Transparent;
            btnPlayGame.Enabled = !status;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnthulai.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnthulai.Width, btnthulai.Height, 3, 3));
            btnConfig.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfig.Width, btnConfig.Height, 3, 3));
            btnPlayGame.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPlayGame.Width, btnPlayGame.Height, 3, 3));
            btnQuit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnQuit.Width, btnQuit.Height, 3, 3));

            this.disableButtons(this.inProccessing);
            //webBrowser_launcher.Url = new Uri(Settings.Default.LauncherUrl);
            string noCacheUrl = Settings.Default.LauncherUrl + "?t=" + DateTime.Now.Ticks;
webBrowser_launcher.Url = new Uri(noCacheUrl);

            this.Activated += AfterLoading;
        }


        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            GetInformationOfDevice();
        }


        #region Get the information of a device
        private static void GetInformationOfDevice()
        {
            var thread = new Thread(() =>
            {
                try
                {
                    //ServicePointManager.Expect100Continue = true;
                    //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    using (WebClient wc = new WebClient())
                    {
                        var method = "POST"; // If your endpoint expects a GET then do it.
                        var parameters = new NameValueCollection();
                        parameters.Add("hwid", DeviceInfoHelper.GetDriveInfo());
                        parameters.Add("client_ip", DeviceInfoHelper.GetPublicIP());
                        parameters.Add("mac_address", DeviceInfoHelper.GetMacAddress());

                        wc.UploadValues(Settings.Default.hwidUrl, method, parameters);
                    }
                }
                catch // (Exception ex)
                {
                    // MessageBox.Show("Không thể xác thực thông tin thiết bị. Vui lòng gửi thông tin sau cho admin." +
                    // "\n- hwid: " + DeviceInfoHelper.GetDriveInfo());
                }
            });
            thread.Start();

        }
        #endregion
        private void Form_downloadFile(string url, string fileName, int type)
        {
            this.downloadingFilename = fileName;
            this.webClient = new WebClient();
            if (type == 1)
            {
                this.webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);
            }
            else if (type == 3)
            {
                this.webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted3);
            }
            else
            {
                this.webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
                this.webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted2);
            }

            string downLoadDestination = Settings.Default.CurrentDirectory + @"\" + fileName;
            string tmpName = Path.GetFileName(downLoadDestination);
            if (Array.Exists(fileSpecials, x => x == tmpName))
            {
                downLoadDestination = this.getTmpDirectory() + @"\" + fileName;
            }

            string dir = Path.GetDirectoryName(downLoadDestination);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            this.webClient.DownloadFileAsync(new Uri(url), (downLoadDestination));

        }

        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            string strFileSize = this.FormatSize(e.TotalBytesToReceive);
            lbStatusText.Text = "Download: " + this.downloadingFilename;
            label_downloadRemain.Text = this.FormatSize(e.BytesReceived) + " / " + strFileSize;
            Double totalPercen = (e.BytesReceived * 100) / e.TotalBytesToReceive;
            totalPercen = Math.Round(totalPercen, 0);
            progressBarCurrent.Value = (int)totalPercen;
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                lbStartupText.Text = "Đang kiểm tra phiên bản ...";
                if (e.Error != null)
                {
                    throw e.Error;
                }
                btnQuit.Enabled = false;

                string versionFilePath = Path.Combine(Settings.Default.CurrentDirectory, Settings.Default.VersionFileName);
                string newMd5 = this.CalculateMD5(versionFilePath);
                string hashFilePath = Path.Combine(Settings.Default.CurrentDirectory, "version.hash");

                if (System.IO.File.Exists(hashFilePath))
                {
                    string oldMd5 = System.IO.File.ReadAllText(hashFilePath).Trim();
                    if (string.Equals(newMd5, oldMd5, StringComparison.OrdinalIgnoreCase))
                    {
                        this.upateCompleted();
                        return;
                    }
                }

                System.IO.File.WriteAllText(hashFilePath, newMd5);

                this.Form_downloadFile(Settings.Default.AutoupdateFileUrl, Settings.Default.AutoupdateFileName, 3);
            }
            catch (Exception ex)
            {
                this.updateFaild(ex);
            }
        }


        private void webClient_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                lbStartupText.Text = "Đang kiểm tra phiên bản ...";
                if (e.Error != null)
                {
                    throw e.Error;
                }

                // checksum autoupdate version compare
                string currenMD5 = this.CalculateMD5(Path.Combine(Settings.Default.CurrentDirectory, Settings.Default.AutoupdateFileName));
                string newMD5 = this.CalculateMD5(Path.Combine(this.getTmpDirectory(), Settings.Default.AutoupdateFileName));
                if (currenMD5 != newMD5)
                {
                    this.restartAppForNewVerion();
                    return;
                }
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                this.updateFaild(ex);
            }

        }

        private void webClient_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null && e.Error.GetType().Name == "WebException")
                {
                    this.updateFaild(e.Error);
                    return;
                }
                if (nNodeIndex < this.filesToDownload.Count)
                {
                    if (nNodeIndex > 0)
                    {
                        totalFilesSizeDl += Convert.ToInt64(this.filesToDownload[nNodeIndex - 1].ChildNodes.Item(3).InnerText.Trim());
                        Double totalPercen = (totalFilesSizeDl * 100) / totalFilesSize;
                        totalPercen = Math.Round(totalPercen, 0);
                        progressBar1.Value = (int)totalPercen;
                    }
                    string filePath = this.filesToDownload[nNodeIndex].ChildNodes.Item(0).InnerText.Trim();
                    string fileLink = this.filesToDownload[nNodeIndex].ChildNodes.Item(1).InnerText.Trim();
                    string fileHash = this.filesToDownload[nNodeIndex].ChildNodes.Item(2).InnerText.Trim();
                    this.Form_downloadFile(Settings.Default.UpdateUrl + fileLink, filePath, 2);
                    nNodeIndex++;
                }
                else
                {
                    this.upateCompleted();
                }

            }
            catch (Exception ex)
            {
                this.updateFaild(ex);
            }

        }

        /* private void btnthulai_Click(object sender, EventArgs e)
         {
             btnConfig.BackColor = Color.Transparent;
             this.downloadVersionFile();
         }*/

        //------------------Cấu Hình------------------------//
        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.runExternalApp("config.exe");
            //btnConfig.BackColor = Color.Transparent;
            //btnConfig.BackgroundImage = Resources.cauhinh3;
            // FormConfig formConfig = new FormConfig();
            // formConfig.ShowDialog();
        }


        private void btnConfig_MouseHover(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.Transparent;
            btnConfig.BackgroundImage = Resources.cauhinh2;
        }

        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.Transparent;
            btnConfig.BackgroundImage = Resources.cauhinh1;
        }
        //---------------------------------------------------//

        //------------------Cấu Hình------------------------//
        /*private void btnfont_Click(object sender, EventArgs e)
        {
            this.runExternalApp(Settings.Default.Suafont);
        }


        private void btnfont_MouseHover(object sender, EventArgs e)
        {
            btnfont.BackColor = Color.Transparent;
            btnfont.BackgroundImage = Resources.fontauto2;
        }

        private void btnfont_MouseLeave(object sender, EventArgs e)
        {
            btnfont.BackColor = Color.Transparent;
            btnfont.BackgroundImage = Resources.fontauto1;
        }*/
        //---------------------------------------------------//


        //------------------Thoát------------------------//
        private void btnQuit_Click(object sender, EventArgs e)
        {
            //this.runExternalApp("config.exe");
            btnQuit.BackColor = Color.Transparent;
            if (this.inProccessing)
            {
                this.webClient.CancelAsync();
                return;
            }
            this.Close();
        }

        private void btnQuit_MouseHover(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.Transparent;
            btnQuit.BackgroundImage = Resources.tat1;
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.Transparent;
            btnQuit.BackgroundImage = Resources.tat2;
        }
        //---------------------------------------------------//

        //------------------Thử Lại------------------------//

        private void btnthulai_Click(object sender, EventArgs e)
        {
            //this.runExternalApp("config.exe");
            btnthulai.BackColor = Color.Transparent;
            this.downloadVersionFile();
        }

        private void btnthulai_MouseHover(object sender, EventArgs e)
        {
            btnthulai.BackColor = Color.Transparent;
            btnthulai.BackgroundImage = Resources.thulai3;
        }

        private void btnthulai_MouseLeave(object sender, EventArgs e)
        {
            btnthulai.BackColor = Color.Transparent;
            btnthulai.BackgroundImage = Resources.thulai2;
        }

        //---------------------------------------------------//


        //------------------AutoPK------------------------//

        private void btnautopk_Click(object sender, EventArgs e)
        {
            //this.runExternalApp("config.exe");
            btnautopk.BackColor = Color.Transparent;
            this.runExternalApp(Settings.Default.AutoPKFile);
        }

        private void btnautopk_MouseHover(object sender, EventArgs e)
        {
            btnautopk.BackColor = Color.Transparent;
            btnautopk.BackgroundImage = Resources.autopk2;
        }

        private void btnautopk_MouseLeave(object sender, EventArgs e)
        {
            btnautopk.BackColor = Color.Transparent;
            btnautopk.BackgroundImage = Resources.autopk1;
        }

        //---------------------------------------------------//

        //------------------Auto KYKX------------------------//

        /*private void btnautokykx_Click(object sender, EventArgs e)
        {
            //this.runExternalApp("config.exe");
            btnautokykx.BackColor = Color.Transparent;
            this.runExternalApp(Settings.Default.AutoKyKx);
        }

        private void btnautokykx_MouseHover(object sender, EventArgs e)
        {
            btnautokykx.BackColor = Color.Transparent;
            btnautokykx.BackgroundImage = Resources.autokimyen21;
        }

        private void btnautokykx_MouseLeave(object sender, EventArgs e)
        {
            btnautokykx.BackColor = Color.Transparent;
            btnautokykx.BackgroundImage = Resources.autokimyen11;
        }*/

        //---------------------------------------------------//


        //------------------Autotrain------------------------//

        private void btnautotrain_Click(object sender, EventArgs e)
        {
            //this.runExternalApp("config.exe");
            btnautotrain.BackColor = Color.Transparent;
            this.runExternalApp(Settings.Default.AutoTrainFile);
        }

        private void btnautotrain_MouseHover(object sender, EventArgs e)
        {
            btnautotrain.BackColor = Color.Transparent;
            btnautotrain.BackgroundImage = Resources.autotrain2;
        }

        private void btnautotrain_MouseLeave(object sender, EventArgs e)
        {
            btnautotrain.BackColor = Color.Transparent;
            btnautotrain.BackgroundImage = Resources.autotrain1;
        }


        //---------------------------------------------------//
        private void btnsuafont_Click(object sender, EventArgs e)
        {
            //this.runExternalApp("config.exe");
            btnsuafont.BackColor = Color.Transparent;
            this.runExternalApp(Settings.Default.Suafont);
        }

        private void btnsuafont_MouseHover(object sender, EventArgs e)
        {
            btnsuafont.BackColor = Color.Transparent;
            btnsuafont.BackgroundImage = Resources.fontauto21;
        }

        private void btnsuafont_MouseLeave(object sender, EventArgs e)
        {
            btnsuafont.BackColor = Color.Transparent;
            btnsuafont.BackgroundImage = Resources.fontauto11;
        }


        //-------------------Đăng Nhập------------------------//

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            btnPlayGame.BackColor = Color.Transparent;
            btnPlayGame.BackgroundImage = Resources.login3;
            string gameFullPath = Path.GetFullPath(Settings.Default.GameFile);
            this.EnsureGame16BitColor(gameFullPath);
            this.runExternalApp(Settings.Default.GameFile);
        }

        private void EnsureGame16BitColor(string gameFullPath)
        {
            const string layersKey = @"Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers";
            const string colorFlag = "16BITCOLOR";
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(layersKey, writable: true)
                                      ?? Registry.CurrentUser.CreateSubKey(layersKey))
                {
                    string current = key.GetValue(gameFullPath) as string ?? "";
                    if (current.IndexOf(colorFlag, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        string newValue = string.IsNullOrEmpty(current.Trim())
                            ? "~ " + colorFlag
                            : current + " " + colorFlag;
                        key.SetValue(gameFullPath, newValue);
                    }
                }
            }
            catch { }
        }

        private void btnPlayGame_MouseHover(object sender, EventArgs e)
        {
            btnPlayGame.BackColor = Color.Transparent;
            btnPlayGame.BackgroundImage = Resources.login3;
        }

        private void btnPlayGame_MouseLeave(object sender, EventArgs e)
        {
            btnPlayGame.BackColor = Color.Transparent;
            btnPlayGame.BackgroundImage = Resources.login2;
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            offset.X = e.X;
            offset.Y = e.Y;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void FormAutoupdate_Shown(object sender, EventArgs e)
        {
            this.downloadVersionFile();
            this.Activate();
        }

        private void downloadVersionFile()
        {
            this.filesToDownload = new List<XmlNode>();
            lbStartupText.Text = "Đang kết nối tới máy chủ ...";
            lbStatusText.Text = "Vui lòng chờ trong giây lát.";
            label_downloadRemain.Text = "";
            this.inProccessing = true;
            this.disableButtons(this.inProccessing);
            this.totalFilesSize = this.totalFilesSizeDl = 0;
            this.nNodeIndex = 0;
            progressBar1.Value = 0;
            progressBarCurrent.Value = 0;
            this.Form_downloadFile(Settings.Default.VersionFileUrl, Settings.Default.VersionFileName, 1);
        }

        private void updateFaild(Exception e)
        {
            //MessageBox.Show(this.filesToDownload[this.nNodeIndex-1].ChildNodes.Item(0).InnerText.Trim());
            //MessageBox.Show(e.ToString());
            lbStartupText.Text = "Kết nối tới máy chủ thất bại! Xin hãy kiểm tra lại intenet.";
            lbStatusText.Text = "";
            this.inProccessing = false;
            progressBar1.Value = 0;
            progressBarCurrent.Value = 0;
            this.disableButtons(this.inProccessing);
            btnPlayGame.BackColor = Color.Transparent;
            btnPlayGame.Enabled = false;
            btnthulai.BackgroundImage = Resources.thulai2;
            btnQuit.Enabled = true;
        }

        private void upateCompleted()
        {
            progressBar1.Value = 100;
            progressBarCurrent.Value = 100;
            lbStartupText.Text = "Cập nhật hoàn tất!";
            lbStatusText.Text = "Hãy Nhấn \"ĐĂNG NHẬP\" để bôn tẩu giang hồ.";
            btnPlayGame.BackColor = Color.Transparent;
            btnPlayGame.BackgroundImage = Resources.login2;
            btnPlayGame.Enabled = true;
            btnthulai.BackColor = Color.Transparent;
            btnthulai.BackgroundImage = Resources.thulai2;
            btnQuit.BackColor = Color.Transparent;
            btnQuit.BackgroundImage = Resources.tat2;
            label_downloadRemain.Text = "";
            this.inProccessing = false;
            this.disableButtons(this.inProccessing);
            string tmpDir = this.getTmpDirectory();
            if (Directory.Exists(tmpDir))
            {
                Directory.Delete(tmpDir, true);
            }

            btnQuit.Enabled = true;
        }

        private bool checkFileToDownload(string path, string hash)
        {
            if (System.IO.File.Exists(path))
            {
                string fileName = Path.GetFileName(path);
                string fileHash = this.CalculateMD5(path);
                bool re = fileHash.ToUpper() == hash.ToUpper();
                return re;
            }
            return false;
        }

        private string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Double percent = (e.ProgressPercentage * 100) / xmlnodes.Count;
            percent = Math.Round(percent, 0);

            string filePath = xmlnodes[e.ProgressPercentage].ChildNodes.Item(0).InnerText.Trim();
            lbStatusText.Text = "Đang kiểm tra [" + filePath + "]";
            progressBarCurrent.Value = (int)percent;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(Path.Combine(Settings.Default.CurrentDirectory, Settings.Default.VersionFileName));
            int i = 0;
            xmlnodes = xmldoc.GetElementsByTagName("Item");
            if (xmlnodes.Count > 0)
            {
                for (i = 0; i <= xmlnodes.Count - 1; i++)
                {
                    backgroundWorker1.ReportProgress(i);

                    string filePath = xmlnodes[i].ChildNodes.Item(0).InnerText.Trim();
                    string fileHash = xmlnodes[i].ChildNodes.Item(2).InnerText.Trim();
                    string localFilePath = Settings.Default.CurrentDirectory + @"\" + filePath;

                    if (!this.checkFileToDownload(localFilePath, fileHash))
                    {
                        Int64 fileSize = Convert.ToInt64(xmlnodes[i].ChildNodes.Item(3).InnerText.Trim());
                        totalFilesSize += fileSize;
                        this.filesToDownload.Add(xmlnodes[i]);
                    }
                }

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnQuit.Enabled = true;

            if (this.filesToDownload.Count > 0)
            {
                string filePath = this.filesToDownload[nNodeIndex].ChildNodes.Item(0).InnerText.Trim();
                string fileLink = this.filesToDownload[nNodeIndex].ChildNodes.Item(1).InnerText.Trim();
                lbStartupText.Text = "Đang cập nhật ...";
                this.Form_downloadFile(Settings.Default.UpdateUrl + fileLink, filePath, 2);
                nNodeIndex++;
            }
            else
            {
                this.upateCompleted();
            }
        }

        private void runExternalApp(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy tập tin " + fileName + "!");
                return;
            }
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = fileName;
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            ExternalProcess.Start();
            //ExternalProcess.WaitForExit();
        }

        private void webBrowser_launcher_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_launcher.Visible = true;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = Properties.Resources.thu3;
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormAutoupdate_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();

                notifyIcon1.Visible = true;

                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
            // btnMinimize.BackgroundImage = Properties.Resources.thu3;
            btnMinimize.BackgroundImage = Resources.thu3;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
            //btnMinimize.BackgroundImage = Properties.Resources.thu1;
            btnMinimize.BackgroundImage = Resources.thu2;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;

                notifyIcon1.Visible = false;
            }
            this.Activate();
        }

        //private void btnMinimize_MouseMove(object sender, MouseEventArgs e)
        //{
        //    btnMinimize.BackgroundImage = Properties.Resources.thu2;
        //    //btnMinimize.BackgroundImage = Properties.Resources.close2;
        //}

        private void ApplyRegionFromPng(Bitmap bmp)
        {
            var bmpData = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] pixels = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixels, 0, bytes);
            bmp.UnlockBits(bmpData);

            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int stride = bmpData.Stride;

            for (int y = 0; y < bmp.Height; y++)
            {
                int xStart = -1;
                for (int x = 0; x < bmp.Width; x++)
                {
                    bool opaque = pixels[y * stride + x * 4 + 3] > 10;
                    if (opaque && xStart < 0)
                        xStart = x;
                    else if (!opaque && xStart >= 0)
                    {
                        path.AddRectangle(new Rectangle(xStart, y, x - xStart, 1));
                        xStart = -1;
                    }
                }
                if (xStart >= 0)
                    path.AddRectangle(new Rectangle(xStart, y, bmp.Width - xStart, 1));
            }

            this.Region = new Region(path);
        }

        private string getTmpDirectory()
        {
            return Path.Combine(Settings.Default.CurrentDirectory, Settings.Default.TmpFolder);
        }

        private void buttons_Paint(object sender, PaintEventArgs e)
        {
            btnMinimize.NotifyDefault(false);
            btnQuit.NotifyDefault(false);
            btnthulai.NotifyDefault(false);
            btnConfig.NotifyDefault(false);
            btnPlayGame.NotifyDefault(false);
        }

        private void restartAppForNewVerion()
        {
            Assembly currenAssembly = Assembly.GetEntryAssembly();
            if (currenAssembly == null)
            {
                currenAssembly = Assembly.GetCallingAssembly();
            }
            string appFolder = Path.GetDirectoryName(currenAssembly.Location);
            string appName = Path.GetFileNameWithoutExtension(currenAssembly.Location);
            string appExtension = Path.GetExtension(currenAssembly.Location);
            string archivePath = Path.Combine(appFolder, appName + "_bak" + appExtension);
            string appPath = Path.Combine(appFolder, appName + appExtension);
            string sourcePath = Path.Combine(this.getTmpDirectory(), Settings.Default.AutoupdateFileName);
            string destinationPath = Path.Combine(Settings.Default.CurrentDirectory, Settings.Default.AutoupdateFileName);

            // move currenAssembly to bak
            System.IO.File.Move(appPath, archivePath);

            // copy new version to replay old version
            System.IO.File.Copy(sourcePath, destinationPath, true);

            // start new version and close current assembly
            this.Hide();
            Thread.Sleep(500);
            this.runExternalApp(Settings.Default.AutoupdateFileName);
            this.Close();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Settings.Default.WebHome);
            }
            catch (Exception)
            {
            }
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = Resources.trangchu2;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = Resources.trangchu1;
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Settings.Default.WebRegister);
            }
            catch (Exception)
            {
            }
        }

        private void btnRegis_MouseHover(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.Transparent;
            btnRegis.BackgroundImage = Resources.dangky2;
        }

        private void btnRegis_MouseLeave(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.Transparent;
            btnRegis.BackgroundImage = Resources.dangky1;
        }

        private void lbStartupText_Click(object sender, EventArgs e)
        {

        }

        private void btnfanpage_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Settings.Default.WebHome);
            }
            catch (Exception)
            {
            }
        }

        private void btnfanpage_MouseHover(object sender, EventArgs e)
        {
            btnfanpage.BackColor = Color.Transparent;
            btnfanpage.BackgroundImage = Resources.fanpage2;
        }

        private void btnfanpage_MouseLeave(object sender, EventArgs e)
        {
            btnfanpage.BackColor = Color.Transparent;
            btnfanpage.BackgroundImage = Resources.fanpage1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}