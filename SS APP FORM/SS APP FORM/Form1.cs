using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_APP_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnss_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);

            Graphics gr =Graphics.FromImage(bm);

            gr.CopyFromScreen(0, 0, 0, 0, new Size(bm.Width, bm.Height));

            pictureBox1.Image = bm
;        }
    }
}
