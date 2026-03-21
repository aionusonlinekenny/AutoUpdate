namespace Autoupdate
{
    partial class FormAutoupdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutoupdate));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnfanpage = new System.Windows.Forms.Button();
            this.btnsuafont = new System.Windows.Forms.Button();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnautopk = new System.Windows.Forms.Button();
            this.btnautotrain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnthulai = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lbStatusText = new System.Windows.Forms.Label();
            this.label_downloadRemain = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBarCurrent = new System.Windows.Forms.ProgressBar();
            this.lbStartupText = new System.Windows.Forms.Label();
            this.webBrowser_launcher = new System.Windows.Forms.WebBrowser();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Đang chạy ở chế độ ẩn vào biểu tượng thanh tác vụ click vào để mở";
            this.notifyIcon1.BalloonTipTitle = "Autoupdate";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Autoupdate";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DarkGray;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanel.CausesValidation = false;
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.btnfanpage);
            this.mainPanel.Controls.Add(this.btnsuafont);
            this.mainPanel.Controls.Add(this.btnRegis);
            this.mainPanel.Controls.Add(this.btnHome);
            this.mainPanel.Controls.Add(this.btnautopk);
            this.mainPanel.Controls.Add(this.btnautotrain);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.btnPlayGame);
            this.mainPanel.Controls.Add(this.btnthulai);
            this.mainPanel.Controls.Add(this.btnQuit);
            this.mainPanel.Controls.Add(this.btnConfig);
            this.mainPanel.Controls.Add(this.btnMinimize);
            this.mainPanel.Controls.Add(this.lbStatusText);
            this.mainPanel.Controls.Add(this.label_downloadRemain);
            this.mainPanel.Controls.Add(this.progressBar1);
            this.mainPanel.Controls.Add(this.progressBarCurrent);
            this.mainPanel.Controls.Add(this.lbStartupText);
            this.mainPanel.Controls.Add(this.webBrowser_launcher);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1284, 741);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-20, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 139);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnfanpage
            // 
            this.btnfanpage.BackColor = System.Drawing.Color.Transparent;
            this.btnfanpage.BackgroundImage = global::Autoupdate.Properties.Resources.fanpage1;
            this.btnfanpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfanpage.CausesValidation = false;
            this.btnfanpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfanpage.FlatAppearance.BorderSize = 0;
            this.btnfanpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfanpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnfanpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfanpage.ForeColor = System.Drawing.Color.Transparent;
            this.btnfanpage.Location = new System.Drawing.Point(446, 455);
            this.btnfanpage.Name = "btnfanpage";
            this.btnfanpage.Size = new System.Drawing.Size(120, 31);
            this.btnfanpage.TabIndex = 37;
            this.btnfanpage.TabStop = false;
            this.btnfanpage.UseMnemonic = false;
            this.btnfanpage.UseVisualStyleBackColor = false;
            this.btnfanpage.Click += new System.EventHandler(this.btnfanpage_Click);
            this.btnfanpage.MouseLeave += new System.EventHandler(this.btnfanpage_MouseLeave);
            this.btnfanpage.MouseHover += new System.EventHandler(this.btnfanpage_MouseHover);
            // 
            // btnsuafont
            // 
            this.btnsuafont.BackColor = System.Drawing.Color.Transparent;
            this.btnsuafont.BackgroundImage = global::Autoupdate.Properties.Resources.fontauto11;
            this.btnsuafont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuafont.CausesValidation = false;
            this.btnsuafont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuafont.FlatAppearance.BorderSize = 0;
            this.btnsuafont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuafont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsuafont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuafont.ForeColor = System.Drawing.Color.Transparent;
            this.btnsuafont.Location = new System.Drawing.Point(995, 578);
            this.btnsuafont.Name = "btnsuafont";
            this.btnsuafont.Size = new System.Drawing.Size(122, 37);
            this.btnsuafont.TabIndex = 36;
            this.btnsuafont.TabStop = false;
            this.btnsuafont.UseMnemonic = false;
            this.btnsuafont.UseVisualStyleBackColor = false;
            this.btnsuafont.Click += new System.EventHandler(this.btnsuafont_Click);
            this.btnsuafont.MouseLeave += new System.EventHandler(this.btnsuafont_MouseLeave);
            this.btnsuafont.MouseHover += new System.EventHandler(this.btnsuafont_MouseHover);
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.Color.Transparent;
            this.btnRegis.BackgroundImage = global::Autoupdate.Properties.Resources.dangky1;
            this.btnRegis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegis.CausesValidation = false;
            this.btnRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegis.FlatAppearance.BorderSize = 0;
            this.btnRegis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegis.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegis.Location = new System.Drawing.Point(446, 410);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(120, 31);
            this.btnRegis.TabIndex = 35;
            this.btnRegis.TabStop = false;
            this.btnRegis.UseMnemonic = false;
            this.btnRegis.UseVisualStyleBackColor = false;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            this.btnRegis.MouseLeave += new System.EventHandler(this.btnRegis_MouseLeave);
            this.btnRegis.MouseHover += new System.EventHandler(this.btnRegis_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::Autoupdate.Properties.Resources.trangchu1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.CausesValidation = false;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Location = new System.Drawing.Point(446, 369);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 31);
            this.btnHome.TabIndex = 34;
            this.btnHome.TabStop = false;
            this.btnHome.UseMnemonic = false;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnautopk
            // 
            this.btnautopk.BackColor = System.Drawing.Color.Transparent;
            this.btnautopk.BackgroundImage = global::Autoupdate.Properties.Resources.autopk1;
            this.btnautopk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnautopk.CausesValidation = false;
            this.btnautopk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnautopk.FlatAppearance.BorderSize = 0;
            this.btnautopk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnautopk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnautopk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnautopk.ForeColor = System.Drawing.Color.Transparent;
            this.btnautopk.Location = new System.Drawing.Point(869, 578);
            this.btnautopk.Name = "btnautopk";
            this.btnautopk.Size = new System.Drawing.Size(120, 38);
            this.btnautopk.TabIndex = 30;
            this.btnautopk.TabStop = false;
            this.btnautopk.UseMnemonic = false;
            this.btnautopk.UseVisualStyleBackColor = false;
            this.btnautopk.Click += new System.EventHandler(this.btnautopk_Click);
            this.btnautopk.MouseLeave += new System.EventHandler(this.btnautopk_MouseLeave);
            this.btnautopk.MouseHover += new System.EventHandler(this.btnautopk_MouseHover);
            // 
            // btnautotrain
            // 
            this.btnautotrain.BackColor = System.Drawing.Color.Transparent;
            this.btnautotrain.BackgroundImage = global::Autoupdate.Properties.Resources.autotrain1;
            this.btnautotrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnautotrain.CausesValidation = false;
            this.btnautotrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnautotrain.FlatAppearance.BorderSize = 0;
            this.btnautotrain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnautotrain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnautotrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnautotrain.ForeColor = System.Drawing.Color.Transparent;
            this.btnautotrain.Location = new System.Drawing.Point(743, 578);
            this.btnautotrain.Name = "btnautotrain";
            this.btnautotrain.Size = new System.Drawing.Size(120, 38);
            this.btnautotrain.TabIndex = 29;
            this.btnautotrain.TabStop = false;
            this.btnautotrain.UseMnemonic = false;
            this.btnautotrain.UseVisualStyleBackColor = false;
            this.btnautotrain.Click += new System.EventHandler(this.btnautotrain_Click);
            this.btnautotrain.MouseLeave += new System.EventHandler(this.btnautotrain_MouseLeave);
            this.btnautotrain.MouseHover += new System.EventHandler(this.btnautotrain_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(612, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hiện Tại : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(612, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Toàn Bộ : ";
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayGame.BackgroundImage = global::Autoupdate.Properties.Resources.login1;
            this.btnPlayGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayGame.CausesValidation = false;
            this.btnPlayGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayGame.FlatAppearance.BorderSize = 0;
            this.btnPlayGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlayGame.Location = new System.Drawing.Point(1087, 354);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(149, 61);
            this.btnPlayGame.TabIndex = 25;
            this.btnPlayGame.TabStop = false;
            this.btnPlayGame.UseMnemonic = false;
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            this.btnPlayGame.MouseLeave += new System.EventHandler(this.btnPlayGame_MouseLeave);
            this.btnPlayGame.MouseHover += new System.EventHandler(this.btnPlayGame_MouseHover);
            // 
            // btnthulai
            // 
            this.btnthulai.BackColor = System.Drawing.Color.Transparent;
            this.btnthulai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthulai.BackgroundImage")));
            this.btnthulai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthulai.CausesValidation = false;
            this.btnthulai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthulai.FlatAppearance.BorderSize = 0;
            this.btnthulai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnthulai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnthulai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthulai.ForeColor = System.Drawing.Color.Transparent;
            this.btnthulai.Location = new System.Drawing.Point(999, 534);
            this.btnthulai.Name = "btnthulai";
            this.btnthulai.Size = new System.Drawing.Size(120, 38);
            this.btnthulai.TabIndex = 22;
            this.btnthulai.TabStop = false;
            this.btnthulai.UseMnemonic = false;
            this.btnthulai.UseVisualStyleBackColor = false;
            this.btnthulai.Click += new System.EventHandler(this.btnthulai_Click);
            this.btnthulai.MouseLeave += new System.EventHandler(this.btnthulai_MouseLeave);
            this.btnthulai.MouseHover += new System.EventHandler(this.btnthulai_MouseHover);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::Autoupdate.Properties.Resources.tat2;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.CausesValidation = false;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(1057, 141);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(30, 30);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.TabStop = false;
            this.btnQuit.UseMnemonic = false;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            this.btnQuit.MouseHover += new System.EventHandler(this.btnQuit_MouseHover);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImage = global::Autoupdate.Properties.Resources.cauhinh1;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.CausesValidation = false;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfig.Location = new System.Drawing.Point(617, 578);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(120, 38);
            this.btnConfig.TabIndex = 20;
            this.btnConfig.TabStop = false;
            this.btnConfig.UseMnemonic = false;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.Paint += new System.Windows.Forms.PaintEventHandler(this.buttons_Paint);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
            this.btnConfig.MouseHover += new System.EventHandler(this.btnConfig_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Autoupdate.Properties.Resources.thu2;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.CausesValidation = false;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(1021, 141);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseMnemonic = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.Paint += new System.Windows.Forms.PaintEventHandler(this.buttons_Paint);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // lbStatusText
            // 
            this.lbStatusText.AutoSize = true;
            this.lbStatusText.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lbStatusText.ForeColor = System.Drawing.Color.White;
            this.lbStatusText.Location = new System.Drawing.Point(614, 523);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(146, 15);
            this.lbStatusText.TabIndex = 7;
            this.lbStatusText.Text = "Vui lòng chờ trong giây lát";
            // 
            // label_downloadRemain
            // 
            this.label_downloadRemain.BackColor = System.Drawing.Color.Transparent;
            this.label_downloadRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.label_downloadRemain.ForeColor = System.Drawing.Color.White;
            this.label_downloadRemain.Location = new System.Drawing.Point(848, 523);
            this.label_downloadRemain.Name = "label_downloadRemain";
            this.label_downloadRemain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_downloadRemain.Size = new System.Drawing.Size(123, 15);
            this.label_downloadRemain.TabIndex = 17;
            this.label_downloadRemain.Text = "0KB / 0KB";
            this.label_downloadRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(684, 562);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // progressBarCurrent
            // 
            this.progressBarCurrent.BackColor = System.Drawing.Color.White;
            this.progressBarCurrent.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBarCurrent.Location = new System.Drawing.Point(684, 546);
            this.progressBarCurrent.Name = "progressBarCurrent";
            this.progressBarCurrent.Size = new System.Drawing.Size(309, 10);
            this.progressBarCurrent.TabIndex = 10;
            // 
            // lbStartupText
            // 
            this.lbStartupText.AutoSize = true;
            this.lbStartupText.BackColor = System.Drawing.Color.Transparent;
            this.lbStartupText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lbStartupText.ForeColor = System.Drawing.Color.White;
            this.lbStartupText.Location = new System.Drawing.Point(614, 508);
            this.lbStartupText.Name = "lbStartupText";
            this.lbStartupText.Size = new System.Drawing.Size(153, 15);
            this.lbStartupText.TabIndex = 6;
            this.lbStartupText.Text = "Đang kết nối tới máy chủ....";
            this.lbStartupText.Click += new System.EventHandler(this.lbStartupText_Click);
            // 
            // webBrowser_launcher
            // 
            this.webBrowser_launcher.AllowNavigation = false;
            this.webBrowser_launcher.AllowWebBrowserDrop = false;
            this.webBrowser_launcher.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser_launcher.Location = new System.Drawing.Point(584, 183);
            this.webBrowser_launcher.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_launcher.Name = "webBrowser_launcher";
            this.webBrowser_launcher.ScrollBarsEnabled = false;
            this.webBrowser_launcher.Size = new System.Drawing.Size(486, 310);
            this.webBrowser_launcher.TabIndex = 5;
            this.webBrowser_launcher.TabStop = false;
            this.webBrowser_launcher.Visible = false;
            this.webBrowser_launcher.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_launcher_DocumentCompleted);
            // 
            // FormAutoupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutoupdate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoUpdate";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormAutoupdate_Shown);
            this.SizeChanged += new System.EventHandler(this.FormAutoupdate_SizeChanged);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.WebBrowser webBrowser_launcher;
        private System.Windows.Forms.Label lbStartupText;
        private System.Windows.Forms.Label lbStatusText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBarCurrent;
        private System.Windows.Forms.Label label_downloadRemain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthulai;
        private System.Windows.Forms.Button btnautopk;
        private System.Windows.Forms.Button btnautotrain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnsuafont;
        private System.Windows.Forms.Button btnfanpage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

