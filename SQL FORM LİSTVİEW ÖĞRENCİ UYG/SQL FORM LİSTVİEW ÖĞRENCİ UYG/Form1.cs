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

namespace SQL_FORM_LİSTVİEW_ÖĞRENCİ_UYG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=TorosDTB;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int id;

        private void veriyigöster()
        {
            connect.Open();
            SqlCommand komutaç = new SqlCommand("Select *from ÖğrenciSistemi1", connect);
            SqlDataReader oku = komutaç.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Sıra"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Şifre"].ToString());
                listView1.Items.Add(ekle);

            }
            connect.Close();
        }

        private void verikaydet()
        {
            connect.Open();

            SqlCommand komutkaydet = new SqlCommand("Insert into ÖğrenciSistemi1 (Ad,Soyad,Şifre) Values ('" + txtad.Text.ToString() + "','" + txtsoyad.Text.ToString() + "','" + txtşifre.Text.ToString() + "') ", connect);

            komutkaydet.ExecuteNonQuery();

            connect.Close();
        }

        private void yenile()
        {
            listView1.Items.Clear();
            veriyigöster();
        }

        private void verisil()
        {
            connect.Open();

            SqlCommand komutsil = new SqlCommand("Delete from ÖğrenciSistemi1 where Sıra = " + id + " ", connect);

            komutsil.ExecuteNonQuery();

            connect.Close();
        }

        private void verigüncelle()
        {
            connect.Open();

            SqlCommand komutgüncelle = new SqlCommand("Update ÖğrenciSistemi1 set Ad='" + txtad.Text.ToString() + "', Soyad='" + txtsoyad.Text.ToString() + "',Şifre='" + txtşifre.Text.ToString() + "' where Sıra="+id+" ", connect);
            komutgüncelle.ExecuteNonQuery();
            connect.Close();
        }

        private void btnaç_Click(object sender, EventArgs e)
        {
            veriyigöster();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            verikaydet();
            yenile();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            verisil();
            yenile();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text.ToString());
            txtad.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            txtşifre.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            verigüncelle();
        }
    }
}
