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

namespace Note_APP_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=TorosDTB;Integrated Security=True");

        private void showdata()
        {
            connect.Open();
            SqlCommand commandshow = new SqlCommand("Select *from TabloNotDefteri", connect);
            SqlDataAdapter da = new SqlDataAdapter(commandshow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg1.DataSource = dt.DefaultView;
            connect.Close();
        }

        private void savedata(string temptext)
        {
            connect.Open();
            SqlCommand commandsave = new SqlCommand("Insert into TabloNotDefteri (Note) values (@notu)",connect);
            commandsave.Parameters.AddWithValue("@notu", temptext);
            commandsave.ExecuteNonQuery();
            connect.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            string text = txtboxnote.Text;
            string date = dp1.Value.ToString();
            string text2 = $"{text} {date}";
            savedata(text2);
            showdata();
        }
    }
}
