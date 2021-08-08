using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması_Form
{
    public partial class KayıtPaneli : Form
    {
        public KayıtPaneli()
        {
            InitializeComponent();
        }

        private void kayıtöğrenci()
        {
            string hashlişifre = encode.ComputeSha256Hash(TxtKayıtŞifre.Text.ToString());

            SqlOperations.bağlantıöğrenci.Open();

            SqlCommand komutkaydet = new SqlCommand("Insert into KütüphaneProjesiÖğrenci (Ad,Soyad,OkulNo,Şifre) Values('"+TxtKayıtAd.Text.ToString()+"','"+TxtKayıtSoyad.Text.ToString()+"','"+TxtKayıtON.Text.ToString()+"','"+hashlişifre.ToString()+"') ",SqlOperations.bağlantıöğrenci);

            komutkaydet.ExecuteNonQuery();

            SqlOperations.bağlantıöğrenci.Close();
        }

        public void girişpanelaç()
        {
            GirişPaneli gpanelaç = new GirişPaneli();
            this.Hide();
            gpanelaç.Show();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {

            if (TxtKayıtŞifre.Text != TxtKayıtŞifre2.Text)
            {
                MessageBox.Show("Şifreler Aynı Değil !");
            }
            else if (TxtKayıtŞifre.Text.Length<8)
            {
                MessageBox.Show("Şifreniz 8 haneden kısa olamaz !");
            }
            else if(TxtKayıtAd.Text==null || TxtKayıtON.Text==null || TxtKayıtSoyad.Text == null )
            {
                MessageBox.Show("Yukarıdaki alanların tamamı doldurulmalıdır !");
            }
            else
            {
                kayıtöğrenci();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            girişpanelaç();
        }
    }
}
