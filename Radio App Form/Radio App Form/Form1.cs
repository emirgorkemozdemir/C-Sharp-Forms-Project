using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_App_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralwmp.radyotvonline.com:80/;";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17703.live.streamtheworld.com/JOY_TURK2.mp3";
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17703.live.streamtheworld.com/METRO_FM.mp3";
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://mpegpowerturk.listenpowerapp.com/powerturk/mpeg/icecast.audio";
        }
    }
}
