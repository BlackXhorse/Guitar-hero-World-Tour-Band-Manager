using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GHWT;
namespace GHWT
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists("settings.ini"))
            {
                if (!Directory.Exists(Form1.ghwtcfolder))
                {
                    MessageBox.Show("Select Your Guitar Hero World Tour Folder");
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();
                        
                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            gamefolder = fbd.SelectedPath;
                            var Myini = new IniFile("settings.ini");
                            Myini.Write("gamefolder", fbd.SelectedPath, "settings");

                        }
                    }
                }
                else
                {
                    gamefolder = Form1.ghwtcfolder;
                }
            }
            else
            {
                var Myini = new IniFile("settings.ini");
                if (Myini.KeyExists("gamefolder", "settings"))
                {
                    gamefolder = Myini.Read("gamefolder", "settings");
                }

            }

            Application.Run(new Form1());
        }
        public static string gamefolder;
        public static string settingsfolder;
    }
}
