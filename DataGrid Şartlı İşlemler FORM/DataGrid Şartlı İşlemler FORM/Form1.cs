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

namespace DataGrid_Şartlı_İşlemler_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showdata();
        }

        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=okul;Integrated Security=True");

        private void showdata()
        {
            connect.Open();

            SqlCommand commandshow = new SqlCommand("Select *from tblUsers", connect);

            SqlDataAdapter da = new SqlDataAdapter(commandshow);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dg1.DataSource = dt.DefaultView;

            connect.Close();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg1.Rows.Count-1; i++)
            {
                DataGridViewCellStyle backcol = new DataGridViewCellStyle();

                if (Convert.ToInt16(dg1.Rows[i].Cells[5].Value)==2)
                {
                    backcol.BackColor = Color.Yellow;
                }

                dg1.Rows[i].DefaultCellStyle = backcol;
            }
        }
    }
}
