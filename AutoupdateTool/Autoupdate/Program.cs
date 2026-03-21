using Autoupdate.Lib;
using Autoupdate.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Autoupdate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Thread.Sleep(100);

            Process p = PriorProcess();

            if (p != null)
            {
                MessageBox.Show("Autoupdate đang chạy");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormAutoupdate());

        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Autoupdate.Resources.Interop.IWshRuntimeLibrary.dll"))
            {
                if (stream != null)
                {
                    byte[] assemblyData = new byte[stream.Length];

                    stream.Read(assemblyData, 0, assemblyData.Length);

                    return Assembly.Load(assemblyData);
                }
                return null;
            }
        }

        public static Process PriorProcess()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if (p.Id != curr.Id && p.MainModule.FileName == curr.MainModule.FileName)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
