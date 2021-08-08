using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialog_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            fd1.ShowDialog();
            fd1.ShowColor = true;
            fd1.ShowEffects = true;
            txtboxnote.Font = fd1.Font;
            txtboxnote.ForeColor = fd1.Color;
        }
    }
}
