using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_cipher_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnencrypt_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text.ToString();

            char[] chars = input.ToCharArray();

            string tempoutput = "";

            foreach (var element in chars)
            {
                tempoutput += Convert.ToChar(element + 5).ToString();
            }

            txtboxresult.Text = tempoutput.ToString();
        }
    }
}
