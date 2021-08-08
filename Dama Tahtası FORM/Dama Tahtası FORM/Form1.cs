using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dama_Tahtası_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] karesayısı = new Button[8, 8];

            var left = 0;
            var top = 0;

            for (int i = 0; i < karesayısı.GetUpperBound(0); i++)
            {
                for (int k = 0; k < karesayısı.GetUpperBound(1); k++)
                {
                    karesayısı[i, k] = new Button();
                    karesayısı[i, k].Width = 50;
                    karesayısı[i, k].Height = 50;
                    karesayısı[i, k].Top = top;
                    karesayısı[i, k].Left = left;
                    left += 50;

                    if ((i+k)%2==0)
                    {
                        karesayısı[i, k].BackColor = Color.Black;
                    }
                    else
                    {
                        karesayısı[i, k].BackColor = Color.White;
                    }
                    this.Controls.Add(karesayısı[i, k]);
                }
                top += 50;
                left = 0;
            }
        }
    }
}
