using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Autoupdate.Properties;

namespace Autoupdate.Lib
{
    class IniAutoupdate
    {
        private INIFile iniFile;
        private string autoupdateINIFile = Path.Combine(Environment.CurrentDirectory, Settings.Default.AutoupdateINI);

        public string secAutoupdate = "Autoupdate";
       /* public string[] UpdateLink = { "UpdateLink", "http://localhost/hostfiles/autoupdate/" };
        public string[] VersionFile = { "VersionFile", "version.xml" };
        public string[] LauncherLink = { "LauncherLink", "http://localhost/launcher" };*/
        public string[] GameFile = { "GameFile", "game.exe" };
        public string[] AutoPKFile = { "AutoPKFile", "game.exe" };
        public string[] AutoTrainFile = { "AutoTrainFile", "game.exe" };
        public string[] AutoKyKx = { "AutoKyKx", "game.exe" };
        public string[] Suafont = { "Suafont", "game.exe" };

        public IniAutoupdate()
        {
            if (File.Exists(this.autoupdateINIFile))
            {
                this.iniFile = new INIFile(this.autoupdateINIFile);
                this.loadConfig();
            }
            else
            {
                this.iniFile = new INIFile(this.autoupdateINIFile);
                this.writeConfig();
            }
        }

        public void writeConfig()
        {
           /* this.iniFile.Write(this.secAutoupdate, this.UpdateLink[0], this.UpdateLink[1]);
            this.iniFile.Write(this.secAutoupdate, this.VersionFile[0], this.VersionFile[1]);
            this.iniFile.Write(this.secAutoupdate, this.LauncherLink[0], this.LauncherLink[1]);*/
            this.iniFile.Write(this.secAutoupdate, this.GameFile[0], this.GameFile[1]);
            this.iniFile.Write(this.secAutoupdate, this.AutoPKFile[0], this.AutoPKFile[1]);
            this.iniFile.Write(this.secAutoupdate, this.AutoTrainFile[0], this.AutoTrainFile[1]);
            this.iniFile.Write(this.secAutoupdate, this.AutoKyKx[0], this.AutoKyKx[1]);
            this.iniFile.Write(this.secAutoupdate, this.Suafont[0], this.Suafont[1]);

        }

        public void loadConfig()
        {
          /*  this.UpdateLink[1] = this.iniFile.Read(this.secAutoupdate, this.UpdateLink[0]);
            this.VersionFile[1] = this.iniFile.Read(this.secAutoupdate, this.VersionFile[0]);
            this.LauncherLink[1] = this.iniFile.Read(this.secAutoupdate, this.LauncherLink[0]);*/
            this.GameFile[1] = this.iniFile.Read(this.secAutoupdate, this.GameFile[0]);
            this.AutoPKFile[1] = this.iniFile.Read(this.secAutoupdate, this.AutoPKFile[0]);
            this.AutoTrainFile[1] = this.iniFile.Read(this.secAutoupdate, this.AutoTrainFile[0]);
            this.AutoKyKx[1] = this.iniFile.Read(this.secAutoupdate, this.AutoKyKx[0]);
            this.Suafont[1] = this.iniFile.Read(this.secAutoupdate, this.Suafont[0]);

        }
    }
}
