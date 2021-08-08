using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Tickets_App_Form_WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenuygun_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.flypgs.com/");
        }

        private void btnbiletbayisi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://biletbayisi.com/?gclid=CjwKCAiApOvwBRBUEiwAcZGdGPTiumusheZ0fuSjjCcE7eqJXm0_PlDjJg_Y8EVzOawJslZbX1-q3xoC6uEQAvD_BwE");
        }

        private void btnucuzabilet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.ucuzabilet.com/?gclid=CjwKCAiApOvwBRBUEiwAcZGdGMvQoMMIhY8veiAiUPhL5xQPCvqMMwYTmeHbmWXFSCmN4Cae0OVtYhoCFXQQAvD_BwE&gclsrc=aw.ds");
        }

        private void btnwego_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.wego.com.tr/flights?wg_source=google&wg_medium=sem&wg_campaign=2079071447&wg_adgroup=76290581226&wg_content=389586093327&wg_term=u%C3%A7ak%20bileti%7Ce&wg_misc=1t4%7Ckwd-259413393%7C&gclid=CjwKCAiApOvwBRBUEiwAcZGdGNMvwsHONv_4DU5svChcFXcFJ4T5n3XgvvSJWePOvH4jwplVPqna_hoCGjQQAvD_BwE");
        }

        private void btnobilet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.obilet.com/ucak-bileti");
        }
    }
}
