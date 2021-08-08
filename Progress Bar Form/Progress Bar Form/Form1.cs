using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnyükle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000;

            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                
                if (progressBar1.Value==progressBar1.Maximum)
                {
                    timer1.Enabled = false;
                }
                else
                {
                    progressBar1.Value += 1;
                    lbox.Items.Add(i);
                }

               
            }
        }
    }
}
