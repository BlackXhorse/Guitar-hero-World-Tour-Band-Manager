using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using GHWT;
using System.IO;

namespace GHWT
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Game Folder: " + Program.gamefolder;

        }
        public static string documentsfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string ghwtdofolder = documentsfolder + "\\My Games\\Guitar Hero World Tour Definitive Edition\\";
        public static string ghwtcfolder = "C:\\Program Files (x86)\\Aspyr\\Guitar Hero World Tour";

        private void bandread()
        {
            var Myini = new IniFile(Program.settingsfolder + "GHWTDE.ini");
            if (Myini.KeyExists("PreferredBassist", "Band"))
            {
                string bass = Myini.Read("PreferredBassist", "Band");
                bassstring.Text = "Bassman: " + bass;

            }
            else
            {
                bassstring.Text = "Bassman: No Found";
            }
            if (Myini.KeyExists("PreferredDrummer", "Band"))
            {
                string drumm = Myini.Read("PreferredDrummer", "Band");
                drumstring.Text = "Drummer: " + drumm;
            }
            else
            {
                drumstring.Text = "Drummer: No Found";
            }
            if (Myini.KeyExists("PreferredSinger", "Band"))
            {
                string singer = Myini.Read("PreferredSinger", "Band");
                vocalstring.Text = "Singer: " + singer;
            }
            else
            {
                vocalstring.Text = "Singer: No Found";
            }
            if (Myini.KeyExists("PreferredGuitarist", "Band"))
            {
                string guitar = Myini.Read("PreferredGuitarist", "Band");
                guitarstring.Text = "Guitarist: " + guitar;
            }
            else
            {
                guitarstring.Text = "Guitarist: No Found";
            }

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Directory.Exists(ghwtdofolder))
            {
                bandread();
                Program.settingsfolder = ghwtdofolder;
            }
            else if (Directory.Exists(ghwtcfolder))
            {
                bandread();
                Program.settingsfolder = ghwtcfolder;
            }
            else
            {
                MessageBox.Show("GHWTDE.ini Not Found Please Select GHWTDE.ini file");
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Title = "Select GHWTDE.ini file";
                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "ini Files (*.ini)|*.ini;";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog1.FileName;
                    Program.settingsfolder = selectedFileName;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            band main = new band();
            main.ShowDialog();
        }
    }
}

