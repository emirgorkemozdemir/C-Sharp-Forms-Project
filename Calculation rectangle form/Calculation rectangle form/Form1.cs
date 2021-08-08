using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation_rectangle_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsqrcal_Click(object sender, EventArgs e)
        {
            int kenar = int.Parse(txtsqr.Text);
            int range = kenar * kenar;
            int perimeter = kenar * 4;
            lblsqrrange.Text = range.ToString();
            lblsqrper.Text = perimeter.ToString();
            lblsqrper.Visible = true;
            lblsqrrange.Visible = true;
        }

        private void btnsqr_Click(object sender, EventArgs e)
        {
            panelsqr.Visible = true;
            panelrect.Visible = false;
        }

        private void btnrect_Click(object sender, EventArgs e)
        {
            panelrect.Visible = true;
            panelsqr.Visible = false;
        }

        private void rectcal_Click(object sender, EventArgs e)
        {
            int kısakenar = int.Parse(txtboxshort.Text);
            int uzunkenar = int.Parse(txtboxlong.Text);

            if (kısakenar >= uzunkenar)
            {
                MessageBox.Show("Your short edge can not be longer than your long edge");
            }
            else
            {
                int alanrect = kısakenar * uzunkenar;
                int çevrerect = (kısakenar + uzunkenar) * 2;

                lblrectrange.Text = alanrect.ToString();
                lblrectper.Text = çevrerect.ToString();

                lblrectper.Visible = true;
                lblrectrange.Visible = true;
            }
        }
    }
}
