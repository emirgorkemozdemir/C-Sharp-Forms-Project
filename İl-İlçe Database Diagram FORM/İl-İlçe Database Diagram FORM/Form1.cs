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

namespace İl_İlçe_Database_Diagram_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=DenemeDTB;Integrated Security=True");

        private void showcity()
        {
            connect.Open();

            SqlCommand commandshow = new SqlCommand("Select *from İlTablosu", connect);

            SqlDataReader dr = commandshow.ExecuteReader();

            while (dr.Read())
            {
                cmbboxil.Items.Add(dr[1].ToString());
            }

            connect.Close();
        }


        private void showvillage()
        {
            connect.Open();

            SqlCommand commandshow2 = new SqlCommand("Select *from İlçeTablosu where ŞehirID="+ Convert.ToInt32(cmbboxil.SelectedIndex+1) +" ", connect);

           

            SqlDataReader dr2 = commandshow2.ExecuteReader();

            while (dr2.Read())
            {
                cmbboxilçe.Items.Add(dr2[1].ToString());
            }

            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showcity();
            
        }

        private void cmbboxil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbboxilçe.Items.Clear();
            showvillage();
        }
    }
}
