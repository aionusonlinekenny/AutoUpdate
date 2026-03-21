using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Autoupdate.Properties;

namespace Autoupdate.Lib
{
    class IniConfig
    {
        private INIFile iniFile;
        private string configFilePath = Path.Combine(Environment.CurrentDirectory, Settings.Default.ConfigFile);
        #region Client Section
            public string secServer = "Server";
            public string[] GameServPort = {"GameServPort", Settings.Default.GameServPort};
            public string[] DenialPort = {"DenialPort", Settings.Default.DenialPort};
        #endregion

        #region Client Section
            public string secClient = "Client";
            public string[] Represent = {"Represent", "2"};
            public string[] CanOpenUrlWhenExit = {"CanOpenUrlWhenExit", "0"};
            public string[] FullScreen = {"FullScreen", "0"};
            public string[] CapPath = { "CapPath", ".\\pic" };
            public string[] FPS = { "FPS", "0" };
            public string[] DynamicLight = { "DynamicLight", "0" };
        #endregion

        public IniConfig()
        {

            if (File.Exists(this.configFilePath))
            {
                this.iniFile = new INIFile(this.configFilePath);
                this.loadConfig();
            }
            else
            {
                this.iniFile = new INIFile(this.configFilePath);
                this.writeConfig();
            }
        }

        public void writeConfig()
        {
            this.iniFile.Write(this.secClient, this.Represent[0], this.Represent[1]);
            this.iniFile.Write(this.secClient, this.CanOpenUrlWhenExit[0], this.CanOpenUrlWhenExit[1]);
            this.iniFile.Write(this.secClient, this.FullScreen[0], this.FullScreen[1]);
            this.iniFile.Write(this.secClient, this.CapPath[0], this.CapPath[1]);
            this.iniFile.Write(this.secClient, this.FPS[0], this.FPS[1]);
            this.iniFile.Write(this.secClient, this.DynamicLight[0], this.DynamicLight[1]);


            this.iniFile.Write(this.secServer, this.GameServPort[0], this.GameServPort[1]);
            this.iniFile.Write(this.secServer, this.DenialPort[0], this.DenialPort[1]);
        }

        public void loadConfig()
        {
            this.GameServPort[1] = this.iniFile.Read(this.secServer, this.GameServPort[0]);
            this.DenialPort[1] = this.iniFile.Read(this.secServer, this.DenialPort[0]);

            this.Represent[1] = this.iniFile.Read(this.secClient, this.Represent[0]);
            this.CanOpenUrlWhenExit[1] = this.iniFile.Read(this.secClient, this.CanOpenUrlWhenExit[0]);
            this.FullScreen[1] = this.iniFile.Read(this.secClient, this.FullScreen[0]);
            this.CapPath[1] = this.iniFile.Read(this.secClient, this.CapPath[0]);
            this.FPS[1] = this.iniFile.Read(this.secClient, this.FPS[0]);
            this.DynamicLight[1] = this.iniFile.Read(this.secClient, this.DynamicLight[0]);
        }
    }
}
