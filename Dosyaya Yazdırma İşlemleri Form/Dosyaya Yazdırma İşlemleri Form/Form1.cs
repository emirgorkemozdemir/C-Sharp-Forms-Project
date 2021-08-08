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

namespace Dosyaya_Yazdırma_İşlemleri_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("Geçmiş.txt", FileMode.Append);

            StreamWriter sr = new StreamWriter(f);

            sr.WriteLine(richTextBox1.Text);

            sr.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Geçmiş.txt", richTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            StreamReader r = new StreamReader("Geçmiş.txt");

            while (!r.EndOfStream)
            {
                richTextBox1.Text += r.ReadLine() + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            List<String> logs = File.ReadLines("Geçmiş.txt").ToList();

            foreach (var metin in logs)
            {
                richTextBox1.Text += metin + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            foreach (var metin in File.ReadLines("Geçmiş.txt"))
            {
                richTextBox1.Text += metin + "\n";
            }
        }
    }
}
