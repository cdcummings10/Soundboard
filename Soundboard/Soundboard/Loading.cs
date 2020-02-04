using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundboard
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();

            bool pathFound = false;
            string settingsPath = "Settings.txt";

            if (!File.Exists(settingsPath))
            {
                File.Create(settingsPath);
            }

            string[] pathFile = File.ReadAllLines(settingsPath);
            if(pathFile[0].Length <= 6)
            {
                PopUpFilePath popUp = new PopUpFilePath();
                popUp.Show();
            }
            else
            {
                Form1 form = new Form1();
                form.Show();
            }
        }

    }
}
