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

namespace Soundboard
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer _player;
        public Form1()
        {
            InitializeComponent();
            _player = new WindowsMediaPlayer();
            _player.URL = "Megalovania [Electro Swing].mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _player.controls.play();
        }
    }
}
