using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;

namespace Folder_Browser_Dialog_Örnek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string yol, ad;

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            ad = txtad.Text.ToString();

            File.AppendAllText(yol + "\\" + ad+".txt", "Selam");
        }

        private void btnyol_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                yol = folderBrowserDialog1.SelectedPath;
                txtyol.Text = yol;
            }
        }
    }
}
