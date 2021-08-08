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
    public partial class GirişPaneli : Form
    {
        public GirişPaneli()
        {
            InitializeComponent();
        }

        public void kayıtpanelaç()
        {
            KayıtPaneli kpanelaç = new KayıtPaneli();
            this.Hide();
            kpanelaç.Show();
        }

        public void öğrencipanelaç()
        {
            ÖğrenciPaneli grş = new ÖğrenciPaneli();
            this.Hide();
            grş.Show();
        }
      

        private void label3_Click(object sender, EventArgs e)
        {
            kayıtpanelaç();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string geçicion, geçicişifre;

        private void şifrekontrol()
        {
            SqlOperations.bağlantıöğrenci.Open();

            SqlCommand komutveriçek = new SqlCommand("Select  *from KütüphaneProjesiÖğrenci where OkulNo ="+geçicion+" ",SqlOperations.bağlantıöğrenci);
         
            SqlDataReader oku = komutveriçek.ExecuteReader();

            if (oku.HasRows)
            {
                while (oku.Read())
                {

                    if (oku["Şifre"].ToString() == geçicişifre)
                    {
                        MessageBox.Show("Giriş Başarılı !!");
                        GlobalVariables.globalloggedON = geçicion;
                        GlobalVariables.globalloggedRank = oku["Derece"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz Yanlış !!");
                        GlobalVariables.globalloggedRank = null;
                        GlobalVariables.globalloggedON = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı sistemde yok!!");
            }
           
          
            SqlOperations.bağlantıöğrenci.Close();

        }


        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            geçicion = TxtGirişON.Text.ToString();
            geçicişifre = encode.ComputeSha256Hash(TxtGirişŞifre.Text.ToString()).Trim();
            şifrekontrol();
            if (GlobalVariables.globalloggedRank==null)
            {
                MessageBox.Show("Herhangi bir derece ile giriş yapılamadı !");
            }
            else if (GlobalVariables.globalloggedRank.ToString()=="3")
            {
                MessageBox.Show("Öğrenci olarak giriş yapıldı !");
                öğrencipanelaç();
            }
        }

    }
}
