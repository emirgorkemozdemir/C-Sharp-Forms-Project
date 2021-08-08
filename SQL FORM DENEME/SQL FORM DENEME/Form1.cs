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

namespace SQL_FORM_DENEME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int id;

        public SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=TorosDTB;Integrated Security=True");

        private void verilerigöster()
        {
            baglantı.Open();

            SqlCommand komutgöster = new SqlCommand("Select *from StudentInfo", baglantı);

            SqlDataReader oku = komutgöster.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku[0].ToString();
                ekle.SubItems.Add(oku[1].ToString());
                ekle.SubItems.Add(oku[2].ToString());
                ekle.SubItems.Add(oku[3].ToString());

                listView1.Items.Add(ekle);

            }

            baglantı.Close();
        }

        private void veriekle()
        {
            baglantı.Open();

            SqlCommand komutekle = new SqlCommand("Insert into StudentInfo (Ad,Soyad,StudentID) Values('"+txtad.Text.ToString()+"','"+txtsoyad.Text.ToString()+"','"+txtno.Text.ToString()+"') ", baglantı);

            komutekle.ExecuteNonQuery();

            baglantı.Close();
        }

        private void pveriekle()
        {
            baglantı.Open();

            SqlCommand komutpekle = new SqlCommand("Insert into StudentInfo (Ad,Soyad,StudentID) Values (@adi,@soyadi,@on)", baglantı);

            komutpekle.Parameters.AddWithValue("@adi", txtad.Text.ToString());

            komutpekle.Parameters.AddWithValue("@soyadi", txtsoyad.Text.ToString());

            komutpekle.Parameters.AddWithValue("@on", txtno.Text.ToString());

            komutpekle.ExecuteNonQuery();

            baglantı.Close();
        }

        private void verisil()
        {
            baglantı.Open();

            SqlCommand komutsil = new SqlCommand("Delete from StudentInfo where Counter=" + id + " ", baglantı);

            komutsil.ExecuteNonQuery();

            baglantı.Close();
        }

        private void veripsil()
        {
            baglantı.Open();

            SqlCommand komutpsil = new SqlCommand("Delete from StudentInfo where StudentID=@on ", baglantı);

            komutpsil.Parameters.AddWithValue("@on", txtsilme.Text.ToString());

            komutpsil.ExecuteNonQuery();

            baglantı.Close();
        }

        private void update()
        {
            baglantı.Open();

            SqlCommand komutupdate = new SqlCommand("Update StudentInfo set Ad='" + txtupad.Text.ToString() + "',Soyad='" + txtupsoyad.Text.ToString() + "', StudentID='" + txtupon.Text.ToString() + "' where Counter="+id+" ", baglantı);

            komutupdate.ExecuteNonQuery();

            baglantı.Close();
        }

        private void ara()
        {
            baglantı.Open();

            SqlCommand komutara = new SqlCommand("Select *from StudentInfo where StudentID like '%"+txtara.Text.ToString()+"%' ", baglantı);

            SqlDataReader oku = komutara.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku[0].ToString();
                ekle.SubItems.Add(oku[1].ToString());
                ekle.SubItems.Add(oku[2].ToString());
                ekle.SubItems.Add(oku[3].ToString());

                listView1.Items.Add(ekle);

            }

            baglantı.Close();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigöster();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            veriekle();
            listView1.Items.Clear();
            verilerigöster();
        }

        private void btnpekle_Click(object sender, EventArgs e)
        {
            pveriekle();
            listView1.Items.Clear();
            verilerigöster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            verisil();
            listView1.Items.Clear();
            verilerigöster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text.ToString());

            txtupad.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();

            txtupsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();

            txtupon.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
        }

        private void btnpsil_Click(object sender, EventArgs e)
        {
            veripsil();
            listView1.Items.Clear();
            verilerigöster();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            listView1.Items.Clear();
            verilerigöster();

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            ara();
        }
    }
}
