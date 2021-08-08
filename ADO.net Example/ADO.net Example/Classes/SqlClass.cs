using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.net_Example.Classes
{
   public class SqlClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=TorosDTB;Integrated Security=True");
    }
}
