using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_FORM_DENEME_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=YazOkuluVeritabanı;Integrated Security=True");

        private void verigöster()
        {
            con.Open();
            SqlCommand komutgöster = new SqlCommand("Select *from ÖğrenciTablosu", con);
            SqlDataReader dr = komutgöster.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                ekle.SubItems.Add(dr[3].ToString());
                ekle.SubItems.Add(dr[4].ToString());
                ekle.SubItems.Add(dr[5].ToString());
                ekle.SubItems.Add(dr[6].ToString());
                listView1.Items.Add(ekle);
            }

            con.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            verigöster();
        }
    }
}
