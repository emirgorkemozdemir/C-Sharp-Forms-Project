using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace IP_Adresi_Uygulaması_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry siteadi = Dns.GetHostEntry(textBox1.Text.ToString());
                IPAddress[] ip = siteadi.AddressList;
                lblsonuc.Text = ip[0].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Böyle bir site yok");
            }
        }
    }
}
