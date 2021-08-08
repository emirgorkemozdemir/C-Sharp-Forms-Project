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

namespace SQL_Giriş_Ekranı_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=TorosDTB;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand commandlogin = new SqlCommand("Select *from KütüphaneProjesiÖğrenci where OkulNo=@nosu and Şifre=@sifi", connect);
            commandlogin.Parameters.AddWithValue("@nosu", txtboxNick.Text.Trim());
            commandlogin.Parameters.AddWithValue("@sifi", txtboxPassword.Text.Trim());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandlogin);
            da.Fill(dt);
            connect.Close();
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 frm = new Form2();
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
    }
}
