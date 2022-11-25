using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GHWT;
using System.IO;
namespace GHWT
{
    public partial class character : Form
    {
        public character()
        {
            InitializeComponent();
            Main();
        }
        
        private void Main()
        {
            Selected.Text = "Selected " + band.artist;
            var Myini = new IniFile(band.selectedcharacterfile);
            modname = Myini.Read("Name", "ModInfo");
            label1.Text = "Name: " + Myini.Read("Name", "ModInfo");
            label2.Text = "Description: " + Myini.Read("Description", "ModInfo");
            label3.Text = "Author: " + Myini.Read("Author", "ModInfo");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Program.settingsfolder))
            {
                var Myini = new IniFile(Program.settingsfolder + "GHWTDE.ini");
                if (band.artist == "vocal")
                {
                    Myini.Write("PreferredSinger", modname, "Band");

                }
                else if(band.artist == "guitar")
                {
                    Myini.Write("PreferredGuitarist", modname, "Band");

                }
                else if (band.artist == "bass")
                {
                    Myini.Write("PreferredBassist", modname, "Band");

                }
                else if (band.artist == "drum")
                {
                    Myini.Write("PreferredDrummer", modname, "Band");

                }
                this.Close();
            }
        }
        public static string modname;
    }
}
