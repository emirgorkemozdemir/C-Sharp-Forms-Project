using ADO.net_Example.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.net_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentDAL studentDAL = new StudentDAL();

        private void Form1_Load(object sender, EventArgs e)
        {
            var studentList = studentDAL.ListStudent();

            dg.DataSource = studentList;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            StudentEntityLayer student = new StudentEntityLayer();

            student.Ad = txtboxad.Text;

            student.Soyad = txtboxsoyad.Text;

            student.OkulNo = txtboxon.Text;

            studentDAL.AddStudent(student);

            var studentList = studentDAL.ListStudent();

            dg.DataSource = studentList;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            StudentEntityLayer student = new StudentEntityLayer();

            student.Ad = txtboxuad.Text;

            student.Soyad = txtboxusoyad.Text;

            student.OkulNo = txtboxuon.Text;

            student.Counter = id;

            studentDAL.UpdateStudent(student);

            var studentList = studentDAL.ListStudent();

            dg.DataSource = studentList;
        }

        int id;

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dg.CurrentRow.Cells[0].Value);

            txtboxuad.Text = dg.CurrentRow.Cells[1].Value.ToString();

            txtboxusoyad.Text = dg.CurrentRow.Cells[2].Value.ToString();

            txtboxuon.Text = dg.CurrentRow.Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
            studentDAL.DeleteStudent(id);

            var studentList = studentDAL.ListStudent();

            dg.DataSource = studentList;
        }
    }
}
