using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value<=0)
            {
                trackBar1.Value = 1;
                lblsize.Text = "1";
                lblletter.Font = new Font("Arial", trackBar1.Value, FontStyle.Regular);
            }
            else
            {
                int fs= trackBar1.Value;
                lblsize.Text = fs.ToString() ;
                lblletter.Font = new Font("Arial", fs, FontStyle.Regular);
            }
        }
    }
}
