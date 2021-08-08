using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_App_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            foreach (var item in openFileDialog1.SafeFileNames)
            {
                lboxad.Items.Add(item);
            }

            foreach (var item2 in openFileDialog1.FileNames)
            {
                lboxyol.Items.Add(item2);
            }

        }

        private void lboxad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxyol.SelectedIndex  = lboxad.SelectedIndex;
            axWindowsMediaPlayer1.URL = lboxyol.Text.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
          
            try
            {
                lboxad.Items.Clear();
                lboxyol.Items.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Boş liste temizlenemez !  ");
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 10;
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 10;
        }

        private void btnçal_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
