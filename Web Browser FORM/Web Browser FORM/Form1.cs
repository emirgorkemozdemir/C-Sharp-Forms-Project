using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnobilet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.obilet.com/otobus-bileti-al");
        }

        private void btnbiletall_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.biletall.com/otobus-bileti");
        }

        private void btnenuygun_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.enuygun.com/otobus-bileti/");
        }

        private void btnneredennereye_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.neredennereye.com/otobus-bileti/");
        }
    }
}
