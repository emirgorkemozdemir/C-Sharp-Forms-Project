using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_App_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void islem(int x1,int x2);

        void topla(int a1, int a2)
        {
            listBox1.Items.Add(a1+a2);
        }

        void cıkar(int b1,int b2)
        {
            listBox1.Items.Add(b1-b2);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            islem i = new islem(topla);
            i += cıkar;

            i(10, 5);


            

           
        }
    }
}
