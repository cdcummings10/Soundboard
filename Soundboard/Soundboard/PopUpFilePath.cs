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
    public partial class PopUpFilePath : Form
    {

        public string Path { get; set; }
        public PopUpFilePath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string settingsPath = "../../Settings.txt";
            if (textBox1.Text != "")
            {
                Path = textBox1.Text;
                File.WriteAllLines(settingsPath, new string[] { $"path: {Path}" });
            }
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox1_TextClicked(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            textBox1.Text = path;
        }
    }
}
