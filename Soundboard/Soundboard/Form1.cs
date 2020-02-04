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
            string path = GetFolderPath();
            string[] clips = Directory.GetFiles(path);


            int top = 10;
            int left = 10;
            int count = 0;
            foreach (string clip in clips)
            {
                if (count % 8 == 0)
                {
                    left = 10;
                    top += 45;
                }
                Button button = new Button();
                button.Top = top;
                button.Left = left;
                int stringClipIndex = clip.LastIndexOf('\\') + 1;
                button.Text = clip.Substring(stringClipIndex, clip.Length - stringClipIndex);
                button.Height = 40;
                button.Width = 150;
                button.Click += new EventHandler((sender, e) => AttachFile(sender, e, clip));
                Controls.Add(button);
                count++;
                left += 155;
            }
        }

        private void AttachFile(object sender, EventArgs e, string path)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player = new WindowsMediaPlayer();
            player.URL = path;
            player.controls.play();
        }

        private string GetFolderPath()
        {
            PopUpFilePath popUp = new PopUpFilePath();
            popUp.Show();
            return popUp.Path;
        }
    }
}
