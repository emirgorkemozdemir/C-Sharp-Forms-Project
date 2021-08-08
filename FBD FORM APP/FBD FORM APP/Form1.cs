using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FBD_FORM_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            File.AppendAllText($@"{path}\{txtboxisim.Text}",richTextBox1.Text);
        }

        string path;

        private void btnyolseç_Click(object sender, EventArgs e)
        {
            fbd1.ShowDialog();

            path = fbd1.SelectedPath.ToString();

            txtboxpath.Text = path;
        }
    }
}
