namespace Autoupdate
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.btnCloseFromConfig = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_change = new System.Windows.Forms.Button();
            this.textBox_pic = new System.Windows.Forms.TextBox();
            this.checkBox_dynamicLight = new System.Windows.Forms.CheckBox();
            this.radioButton_window = new System.Windows.Forms.RadioButton();
            this.radioButton_3d = new System.Windows.Forms.RadioButton();
            this.radioButton_fullscreen = new System.Windows.Forms.RadioButton();
            this.radioButton_2d = new System.Windows.Forms.RadioButton();
            this.button_default = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseFromConfig
            // 
            this.btnCloseFromConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFromConfig.BackgroundImage = global::Autoupdate.Properties.Resources.close3;
            this.btnCloseFromConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseFromConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFromConfig.FlatAppearance.BorderSize = 0;
            this.btnCloseFromConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseFromConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseFromConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFromConfig.Location = new System.Drawing.Point(373, 7);
            this.btnCloseFromConfig.Name = "btnCloseFromConfig";
            this.btnCloseFromConfig.Size = new System.Drawing.Size(20, 20);
            this.btnCloseFromConfig.TabIndex = 0;
            this.btnCloseFromConfig.UseVisualStyleBackColor = false;
            this.btnCloseFromConfig.Click += new System.EventHandler(this.btnCloseFromConfig_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.BackgroundImage = global::Autoupdate.Properties.Resources.jx_config_bg;
            this.panel2.Controls.Add(this.button_change);
            this.panel2.Controls.Add(this.textBox_pic);
            this.panel2.Controls.Add(this.checkBox_dynamicLight);
            this.panel2.Controls.Add(this.radioButton_window);
            this.panel2.Controls.Add(this.radioButton_3d);
            this.panel2.Controls.Add(this.radioButton_fullscreen);
            this.panel2.Controls.Add(this.radioButton_2d);
            this.panel2.Controls.Add(this.button_default);
            this.panel2.Controls.Add(this.button_ok);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 292);
            this.panel2.TabIndex = 2;
            // 
            // button_change
            // 
            this.button_change.AutoEllipsis = true;
            this.button_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(121)))));
            this.button_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_change.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(56)))));
            this.button_change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(143)))));
            this.button_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button_change.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_change.Location = new System.Drawing.Point(323, 202);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(32, 21);
            this.button_change.TabIndex = 12;
            this.button_change.TabStop = false;
            this.button_change.Text = "...";
            this.button_change.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_change.UseMnemonic = false;
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // textBox_pic
            // 
            this.textBox_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pic.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_pic.Location = new System.Drawing.Point(27, 202);
            this.textBox_pic.Name = "textBox_pic";
            this.textBox_pic.Size = new System.Drawing.Size(290, 21);
            this.textBox_pic.TabIndex = 11;
            this.textBox_pic.TabStop = false;
            this.textBox_pic.TextChanged += new System.EventHandler(this.textBox_pic_TextChanged);
            // 
            // checkBox_dynamicLight
            // 
            this.checkBox_dynamicLight.AutoSize = true;
            this.checkBox_dynamicLight.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_dynamicLight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.checkBox_dynamicLight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_dynamicLight.Location = new System.Drawing.Point(38, 138);
            this.checkBox_dynamicLight.Name = "checkBox_dynamicLight";
            this.checkBox_dynamicLight.Size = new System.Drawing.Size(133, 20);
            this.checkBox_dynamicLight.TabIndex = 10;
            this.checkBox_dynamicLight.TabStop = false;
            this.checkBox_dynamicLight.Text = "Ánh sáng động";
            this.checkBox_dynamicLight.UseVisualStyleBackColor = false;
            this.checkBox_dynamicLight.CheckedChanged += new System.EventHandler(this.checkBox_dynamicLight_CheckedChanged);
            // 
            // radioButton_window
            // 
            this.radioButton_window.AutoCheck = false;
            this.radioButton_window.AutoSize = true;
            this.radioButton_window.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_window.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.radioButton_window.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton_window.Location = new System.Drawing.Point(228, 107);
            this.radioButton_window.Name = "radioButton_window";
            this.radioButton_window.Size = new System.Drawing.Size(75, 20);
            this.radioButton_window.TabIndex = 9;
            this.radioButton_window.Text = "Cửa sổ";
            this.radioButton_window.UseVisualStyleBackColor = false;
            this.radioButton_window.Click += new System.EventHandler(this.radioButton_window_Click);
            // 
            // radioButton_3d
            // 
            this.radioButton_3d.AutoCheck = false;
            this.radioButton_3d.AutoSize = true;
            this.radioButton_3d.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_3d.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.radioButton_3d.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton_3d.Location = new System.Drawing.Point(38, 107);
            this.radioButton_3d.Name = "radioButton_3d";
            this.radioButton_3d.Size = new System.Drawing.Size(44, 20);
            this.radioButton_3d.TabIndex = 8;
            this.radioButton_3d.Text = "3D";
            this.radioButton_3d.UseVisualStyleBackColor = false;
            this.radioButton_3d.Click += new System.EventHandler(this.radioButton_3d_Click);
            // 
            // radioButton_fullscreen
            // 
            this.radioButton_fullscreen.AutoCheck = false;
            this.radioButton_fullscreen.AutoSize = true;
            this.radioButton_fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_fullscreen.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.radioButton_fullscreen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton_fullscreen.Location = new System.Drawing.Point(228, 72);
            this.radioButton_fullscreen.Name = "radioButton_fullscreen";
            this.radioButton_fullscreen.Size = new System.Drawing.Size(127, 20);
            this.radioButton_fullscreen.TabIndex = 7;
            this.radioButton_fullscreen.Text = "Toàn màn hình";
            this.radioButton_fullscreen.UseVisualStyleBackColor = false;
            this.radioButton_fullscreen.Click += new System.EventHandler(this.radioButton_fullscreen_Click);
            // 
            // radioButton_2d
            // 
            this.radioButton_2d.AutoCheck = false;
            this.radioButton_2d.AutoSize = true;
            this.radioButton_2d.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_2d.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.radioButton_2d.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButton_2d.Location = new System.Drawing.Point(38, 72);
            this.radioButton_2d.Name = "radioButton_2d";
            this.radioButton_2d.Size = new System.Drawing.Size(44, 20);
            this.radioButton_2d.TabIndex = 6;
            this.radioButton_2d.Text = "2D";
            this.radioButton_2d.UseVisualStyleBackColor = false;
            this.radioButton_2d.Click += new System.EventHandler(this.radioButton_2d_Click);
            // 
            // button_default
            // 
            this.button_default.AutoEllipsis = true;
            this.button_default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(121)))));
            this.button_default.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_default.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_default.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_default.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(56)))));
            this.button_default.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(143)))));
            this.button_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_default.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.button_default.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_default.Location = new System.Drawing.Point(272, 243);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(83, 30);
            this.button_default.TabIndex = 5;
            this.button_default.TabStop = false;
            this.button_default.Text = "MẶC ĐỊNH";
            this.button_default.UseMnemonic = false;
            this.button_default.UseVisualStyleBackColor = true;
            this.button_default.Click += new System.EventHandler(this.button_default_Click);
            // 
            // button_ok
            // 
            this.button_ok.AutoEllipsis = true;
            this.button_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(121)))));
            this.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(56)))));
            this.button_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(143)))));
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.button_ok.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_ok.Location = new System.Drawing.Point(27, 243);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(83, 30);
            this.button_ok.TabIndex = 4;
            this.button_ok.TabStop = false;
            this.button_ok.Text = "THIẾT LẬP";
            this.button_ok.UseMnemonic = false;
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thư mục lưu ảnh chụp màn hình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chế độ hiển thị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(123, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIẾT LẬP GAME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 294);
            this.panel1.TabIndex = 1;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnCloseFromConfig);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfig";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnCloseFromConfig;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.TextBox textBox_pic;
        private System.Windows.Forms.CheckBox checkBox_dynamicLight;
        private System.Windows.Forms.RadioButton radioButton_window;
        private System.Windows.Forms.RadioButton radioButton_3d;
        private System.Windows.Forms.RadioButton radioButton_fullscreen;
        private System.Windows.Forms.RadioButton radioButton_2d;
        private System.Windows.Forms.Button button_default;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}