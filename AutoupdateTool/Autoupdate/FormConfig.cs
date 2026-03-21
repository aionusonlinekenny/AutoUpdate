using Autoupdate.Lib;
using System;
using System.Windows.Forms;

namespace Autoupdate
{
    public partial class FormConfig : Form
    {
        IniConfig iniConfig;
        public FormConfig()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.iniConfig = new IniConfig();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            textBox_pic.Text = this.iniConfig.CapPath[1];
            folderBrowserDialog1.SelectedPath = this.iniConfig.CapPath[1];

            radioButton_fullscreen.Checked = this.iniConfig.FullScreen[1] == "1";
            radioButton_window.Checked = this.iniConfig.FullScreen[1] == "0";

            radioButton_2d.Checked = this.iniConfig.Represent[1] == "2";
            radioButton_3d.Checked = this.iniConfig.Represent[1] == "3";

            checkBox_dynamicLight.Enabled = this.iniConfig.Represent[1] == "3";
            checkBox_dynamicLight.Checked = this.iniConfig.DynamicLight[1] == "1";


        }

        private void btnCloseFromConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox_pic.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void radioButton_2d_Click(object sender, EventArgs e)
        {
            checkBox_dynamicLight.Checked = false;
            checkBox_dynamicLight.Enabled = false;
            radioButton_2d.Checked = true;
            radioButton_3d.Checked = false;
            this.iniConfig.Represent[1] = "2";
            this.iniConfig.DynamicLight[1] = "0";
        }

        private void radioButton_3d_Click(object sender, EventArgs e)
        {
            checkBox_dynamicLight.Enabled = true;
            radioButton_2d.Checked = false;
            radioButton_3d.Checked = true;
            this.iniConfig.Represent[1] = "3";
        }

        private void radioButton_fullscreen_Click(object sender, EventArgs e)
        {
            radioButton_window.Checked = false;
            radioButton_fullscreen.Checked = true;
            this.iniConfig.FullScreen[1] = "1";
        }

        private void radioButton_window_Click(object sender, EventArgs e)
        {
            radioButton_window.Checked = true;
            radioButton_fullscreen.Checked = false;
            this.iniConfig.FullScreen[1] = "0";
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.iniConfig.writeConfig();
            this.Close();
        }

        private void button_default_Click(object sender, EventArgs e)
        {
            radioButton_2d.Checked = true;
            radioButton_3d.Checked = false;
            this.iniConfig.Represent[1] = "2";

            radioButton_fullscreen.Checked = false;
            radioButton_window.Checked = true;
            this.iniConfig.FullScreen[1] = "0";

            checkBox_dynamicLight.Checked = false;
            checkBox_dynamicLight.Enabled = false;
            this.iniConfig.DynamicLight[1] = "0";

            textBox_pic.Text = this.iniConfig.CapPath[1] = ".\\pic";
            folderBrowserDialog1.SelectedPath = this.iniConfig.CapPath[1];

            this.iniConfig.writeConfig();
        }

        private void checkBox_dynamicLight_CheckedChanged(object sender, EventArgs e)
        {
            this.iniConfig.DynamicLight[1] = checkBox_dynamicLight.Checked ? "1" : "0";
        }

        private void textBox_pic_TextChanged(object sender, EventArgs e)
        {
            this.iniConfig.CapPath[1] = textBox_pic.Text;
        }
    }
}