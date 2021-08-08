using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_MEDIA_PLAYER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ofd1.ShowDialog();

            lboxmusics.Items.Add(ofd1.FileName.ToString());
        }

        private void btnseç_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=lboxmusics.SelectedItem.ToString();

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
