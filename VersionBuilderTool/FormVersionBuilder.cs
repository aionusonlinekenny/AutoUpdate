using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace Autoupdate.Tools
{
    public partial class FormVersionBuilder : Form
    {
        public FormVersionBuilder()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBoxSource.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML Files|version.xml";
                sfd.FileName = "version.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutput.Text = sfd.FileName;
                }
            }
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOutput.Text))
            {
                string suggestedPath = Path.Combine(textBoxSource.Text, "version.xml");
                textBoxOutput.Text = suggestedPath;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string sourceFolder = textBoxSource.Text;
            string outputFile = textBoxOutput.Text;

            if (!Directory.Exists(sourceFolder))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại.");
                return;
            }

            // Lấy danh sách file, loại bỏ version.xml và version.xml.md5 nếu nằm trong thư mục nguồn
            var files = Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories)
                .Where(f => !f.Equals(outputFile, StringComparison.OrdinalIgnoreCase)
                         && !f.Equals(outputFile + ".md5", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            progressBar1.Value = 0;
            labelStatus.Text = "Bắt đầu tạo version.xml...";

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Files");
            xmlDoc.AppendChild(root);

            for (int i = 0; i < files.Length; i++)
            {
                var filePath = files[i];
                // GetRelativePath trả về forward slashes từ Uri
                string relativeRaw = GetRelativePath(sourceFolder, filePath);

                // <Path>: dùng backslash vì AutoUpdateTool dùng để ghép đường dẫn Windows
                //   CurrentDirectory + "\" + Path  →  cần  "subfolder\file.exe"
                string pathValue = relativeRaw.Replace("/", "\\");

                // <Link>: dùng forward slash, KHÔNG có dấu "/" đầu
                //   AutoUpdateTool ghép:  UpdateUrl + Link  (UpdateUrl đã kết thúc bằng "/")
                //   → cần  "subfolder/file.exe"  để tránh double-slash trong URL
                string linkValue = relativeRaw.Replace("\\", "/");

                string md5 = CalculateMD5(filePath);
                long size = new FileInfo(filePath).Length;

                XmlElement item = xmlDoc.CreateElement("Item");

                XmlElement pathNode = xmlDoc.CreateElement("Path");
                pathNode.InnerText = pathValue;
                item.AppendChild(pathNode);

                XmlElement linkNode = xmlDoc.CreateElement("Link");
                linkNode.InnerText = linkValue;
                item.AppendChild(linkNode);

                XmlElement md5Node = xmlDoc.CreateElement("MD5");
                md5Node.InnerText = md5;
                item.AppendChild(md5Node);

                XmlElement sizeNode = xmlDoc.CreateElement("Size");
                sizeNode.InnerText = size.ToString();
                item.AppendChild(sizeNode);

                root.AppendChild(item);

                // Cập nhật tiến trình
                int percent = (int)(((i + 1) * 100.0) / files.Length);
                progressBar1.Value = percent;
                labelStatus.Text = $"Đang xử lý: {pathValue} ({percent}%)";
                Application.DoEvents();
            }

            xmlDoc.Save(outputFile);
            string versionMd5 = CalculateMD5(outputFile);
            Clipboard.SetText(versionMd5); // Tự động copy ra clipboard cho dễ dán
            File.WriteAllText(outputFile + ".md5", versionMd5);
            MessageBox.Show("Tạo version.xml thành công!\nMã MD5 tổng: " + versionMd5, "Thông báo");

        }

        private string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            using (var stream = File.OpenRead(filename))
            {
                var hash = md5.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        private string GetRelativePath(string basePath, string fullPath)
        {
            Uri baseUri = new Uri(basePath.EndsWith("\\") ? basePath : basePath + "\\");
            Uri fullUri = new Uri(fullPath);
            return Uri.UnescapeDataString(baseUri.MakeRelativeUri(fullUri).ToString());
        }
    }
}
