using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_App_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum months
        {
            Ocak,Şubat,Mart,Nisan,Mayıs,Haziran,Temmuz,Ağustos,Eylül,Ekim,Kasım,Aralık
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int aynumarası = Convert.ToInt16(txtboxnum.Text);

            months m;

            m = (months)aynumarası-1;

            lblmonth.Text = m.ToString();
        }
    }
}
