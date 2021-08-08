using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_app_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            adtekrarlbl.Text = txtboxadsoyad.Text;
            teltekrarlbl.Text = txtboxtelefon.Text;
            lblmenü.Text = cmbboxboy.Text;
            lstboxadsoyad.Items.Add(adtekrarlbl.Text.ToString());
            lstboxadres.Items.Add(txtboxadres.Text.ToString());
            lstboxboy.Items.Add(lblmenü.Text.ToString());
            lstboxtel.Items.Add(teltekrarlbl.Text.ToString());
            lstboxextras.Items.Add(lbltuz.Text+""+lblso.Text+""+lblmay.Text+""+lblhar.Text+""+lblket.Text);
        }

        private void chboxket_CheckedChanged(object sender, EventArgs e)
        {
            lblket.Visible = true;
            lblket.Text = chboxket.Text;
            if (chboxket.Checked==false)
            {
                lblket.Text = "";
            }
        }

        private void chboxmay_CheckedChanged(object sender, EventArgs e)
        {
            lblmay.Visible = true;
            lblmay.Text = chboxmay.Text;
            if(chboxmay.Checked==false)
            {
                lblmay.Text = "";
            }
        }

        private void chboxhar_CheckedChanged(object sender, EventArgs e)
        {
            lblhar.Visible = true;
            lblhar.Text = chboxhar.Text;
            if (chboxhar.Checked == false)
            {
                lblhar.Text = "";
            }
        }

        private void chboxso_CheckedChanged(object sender, EventArgs e)
        {
            lblso.Visible = true;
            lblso.Text = chboxso.Text;
            if (chboxso.Checked == false)
            {
                lblso.Text = "";
            }
        }

        private void chboxtuz_CheckedChanged(object sender, EventArgs e)
        {
            lbltuz.Visible = true;
            lbltuz.Text = chboxtuz.Text;
            if (chboxtuz.Checked == false)
            {
                lbltuz.Text = "";
            }
        }

    }
}
