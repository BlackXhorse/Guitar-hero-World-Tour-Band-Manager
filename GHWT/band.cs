using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GHWT;
namespace GHWT
{
    public partial class band : Form
    {
        public band()
        {
            InitializeComponent();
        }
        public static string selectedcharacterfile;
        public static string artist;

        private void selectfile(string artistt)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select The Character ini FIle (.ini)";
            if (Directory.Exists(Program.gamefolder))
            {
                openFileDialog1.InitialDirectory = Program.gamefolder;
            }
            else
            {
                openFileDialog1.InitialDirectory = "C:\\";
            }
            openFileDialog1.Filter = "Ini Files (*.ini)|*.ini";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                selectedcharacterfile = selectedFileName;
                artist = artistt;
                character main = new character();
                main.ShowDialog();
                this.Close();

            }
        }
        private void vocal_Click(object sender, EventArgs e)
        {
            selectfile("vocal");
        }

        private void guitar_Click(object sender, EventArgs e)
        {
            selectfile("guitar");
        }

        private void bass_Click(object sender, EventArgs e)
        {
            selectfile("bass");
        }

        private void drum_Click(object sender, EventArgs e)
        {
            selectfile("drum");
        }
    }
}
