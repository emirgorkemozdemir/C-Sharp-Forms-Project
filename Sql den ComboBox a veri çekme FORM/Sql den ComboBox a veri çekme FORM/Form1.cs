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

namespace Sql_den_ComboBox_a_veri_çekme_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=DenemeDTB;Integrated Security=True");

        private void showdata()
        {
            connect.Open();

            SqlCommand commandshow = new SqlCommand("Select *from İlTablosu", connect);

            SqlDataAdapter da = new SqlDataAdapter(commandshow);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbbox.DataSource = dt;
            cmbbox.ValueMember = "İlID";
            cmbbox.DisplayMember = "İlAdı";

            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
