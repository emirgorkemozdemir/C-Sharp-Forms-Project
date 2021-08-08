using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Operations_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ad = txtboxName.Text;
            string path = txtboxPath.Text;

            Directory.CreateDirectory($@"{path}\\"+ ad);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ad = txtboxName.Text;
            string path = txtboxPath.Text;
            Directory.Delete($@"{path}\\" + ad);
        }

        private void btncreation_Click(object sender, EventArgs e)
        {
            string ad = txtboxName.Text;
            string path = txtboxPath.Text;

            MessageBox.Show(Directory.GetCreationTime($@"{path}\\" + ad).ToString());
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
        }

        private void btnlastaccess_Click(object sender, EventArgs e)
        {
            string ad = txtboxName.Text;
            string path = txtboxPath.Text;

            MessageBox.Show(Directory.GetLastAccessTime($@"{path}\\" + ad).ToString());
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string ad = txtboxName.Text;
            string yeniad = txtboxnewname.Text;
            string path = txtboxPath.Text;

            Directory.Move($@"{path}\{ad}", $@"{path}\{yeniad}");
        }
    }
}
