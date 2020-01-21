using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Soundboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] clips = Directory.GetFiles(@"C:\Users\Menalaus\Documents\Soundboard");


            int top = 50;
            int left = 100;

            foreach (string clip in clips)
            {
                Button button = new Button();
                button.Top = top;
                button.Left = left;
                top += 50;
                int stringClipIndex = clip.LastIndexOf('\\') + 1;
                button.Text = clip.Substring(stringClipIndex, clip.Length -stringClipIndex);
                button.Height = 40;
                button.Width = 200;
                button.Click += new EventHandler((sender, e) => AttachFile(sender, e, clip));
                Controls.Add(button);
            }
        }

        private void AttachFile(object sender, EventArgs e, string path)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player = new WindowsMediaPlayer();
            player.URL = path;
            player.controls.play();
        }
    }
}
