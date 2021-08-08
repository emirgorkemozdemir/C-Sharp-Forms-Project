using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet_APP_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       DataSet1TableAdapters.ÖrnekKitapListesiTableAdapter adapter= new DataSet1TableAdapters.ÖrnekKitapListesiTableAdapter();

        DataSet1.ÖrnekKitapListesiDataTable dt = new DataSet1.ÖrnekKitapListesiDataTable();

        private void showdata()
        {
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
