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

namespace DOSYA_KAYDETME_OKUTMA_YÖNTEMLERİ_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string seçiliad;
      

        private void btnkayıt1_Click(object sender, EventArgs e)
        {
            seçiliad = txtkayıt.Text.ToString();

            FileStream fs = new FileStream("logs.txt", FileMode.Append);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(seçiliad);

            sw.Close();

        }

        private void btnkayıt2_Click(object sender, EventArgs e)
        {
            seçiliad = txtkayıt.Text.ToString();

            File.AppendAllText("logs.txt", $"{seçiliad}\n");
        }

        private void btnread1_Click(object sender, EventArgs e)
        {
            lbox.Items.Clear();

            StreamReader sr = new StreamReader("logs.txt");

            while (! sr.EndOfStream)
            {
                lbox.Items.Add(sr.ReadLine());
            }

            sr.Close();
        }

        private void btnoku2_Click(object sender, EventArgs e)
        {
            lbox.Items.Clear();

            List<string> logs = File.ReadAllLines("logs.txt").ToList();

            foreach (var items in logs)
            {
                lbox.Items.Add(items);
            }
        }
    }
}
