using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_App_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i <= 23; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int k = 0; k < 60; k++)
            {
                comboBox2.Items.Add(k);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhour.Text = DateTime.Now.Hour.ToString();
            lblminute.Text = DateTime.Now.Minute.ToString();
            lblsecond.Text = DateTime.Now.Second.ToString();

            if (comboBox1.Text == lblhour.Text && comboBox2.Text == lblminute.Text)
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = "C:\\Users\\ACER\\Desktop\\frog.wav";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

       
    }
}
