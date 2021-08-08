using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADO.net_Example.Classes
{
  public  class StudentDAL
    {
        public List<StudentEntityLayer> ListStudent()
        {
            List<StudentEntityLayer> tempList = new List<StudentEntityLayer>();

            SqlCommand commandlist = new SqlCommand("Select *from StudentInfo", SqlClass.connection);

            if (commandlist.Connection.State==ConnectionState.Closed)
            {
                commandlist.Connection.Open();
            }

            SqlDataReader dataReader = commandlist.ExecuteReader();

            while (dataReader.Read())
            {
                StudentEntityLayer student = new StudentEntityLayer();
                student.Ad = dataReader[1].ToString();
                student.Counter = (int)dataReader[0];
                student.Soyad = dataReader[2].ToString();
                student.OkulNo = dataReader[3].ToString();
                tempList.Add(student);
            }

            dataReader.Close();

            return tempList;
        }

        public void AddStudent(StudentEntityLayer ent)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into StudentInfo (Ad,Soyad,StudentID) values (@pad,@psoyad,@pon)", SqlClass.connection);

            commandAdd.Parameters.AddWithValue("@pad", ent.Ad);

            commandAdd.Parameters.AddWithValue("@psoyad", ent.Soyad);

            commandAdd.Parameters.AddWithValue("@pon", ent.OkulNo);

            commandAdd.ExecuteNonQuery();
        }

        public void UpdateStudent(StudentEntityLayer ent)
        {
            SqlCommand commandUpdate = new SqlCommand("Update StudentInfo set Ad=@pad , Soyad=@psoyad , StudentID=@pod where Counter=@pid", SqlClass.connection);

            if (commandUpdate.Connection.State==ConnectionState.Closed)
            {
                commandUpdate.Connection.Open();
            }

            commandUpdate.Parameters.AddWithValue("@pad", ent.Ad);

            commandUpdate.Parameters.AddWithValue("@psoyad", ent.Soyad);

            commandUpdate.Parameters.AddWithValue("@pod", ent.OkulNo);

            commandUpdate.Parameters.AddWithValue("@pid", ent.Counter);

            commandUpdate.ExecuteNonQuery();
        }

        public void DeleteStudent(int tempid)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from StudentInfo where Counter=@pid", SqlClass.connection);


            if (commandDelete.Connection.State == ConnectionState.Closed)
            {
                commandDelete.Connection.Open();
            }

            commandDelete.Parameters.AddWithValue("@pid", tempid);

            commandDelete.ExecuteNonQuery();
        }
    }
}
