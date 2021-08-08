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
    public partial class KitapRezerve : Form
    {
        public KitapRezerve()
        {
            InitializeComponent();
        }

        public void öğrencipanelaç()
        {
            ÖğrenciPaneli grş = new ÖğrenciPaneli();
            this.Hide();
            grş.Show();
        }


        public string geçicika;

        private void kitapal()
        {

            int sayaç = 0;

            SqlOperations.bağlantıkitap.Open();

            SqlCommand komutara = new SqlCommand("Select *from KütüphaneProjesiKitap where KitapAdı like '%" + TxtAra.Text.ToString() + "%' ", SqlOperations.bağlantıkitap);

            SqlDataReader oku = komutara.ExecuteReader();


            if (oku.HasRows)
            {
               

                while (oku.Read())
                {
                    if (oku["Durumu"].ToString() == "Var")
                    {
                        MessageBox.Show("Kitap okul numaranıza rezerve edilmiştir, en kısa zamanda kütüphaneden alınız.");
                        geçicika = TxtAra.Text.ToString();
                        sayaç++;
                       
                    }
                    else
                    {
                        MessageBox.Show("Kitap başkası tarafından kullanımdadır,ayrıntılı bilgi için kütüphaneye başvurunuz.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kitap sistemde bulunmamaktadır.");
            }


            SqlOperations.bağlantıkitap.Close();

            if (sayaç!=0)
            {
                kitabırezerve();
            }
        }

        private void kitabırezerve()
        {
            SqlOperations.bağlantıkitap.Open();

            SqlCommand komutaktar = new SqlCommand("Insert into RezerveTablosu (KitapAlanON,AlınanKitap) Values('" + GlobalVariables.globalloggedON + "','" + geçicika + "') ", SqlOperations.bağlantıkitap);

            
            komutaktar.ExecuteNonQuery();

            SqlOperations.bağlantıkitap.Close();
        }

        private void BtnAl_Click(object sender, EventArgs e)
        {
            kitapal();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            öğrencipanelaç();
        }

    }
}
