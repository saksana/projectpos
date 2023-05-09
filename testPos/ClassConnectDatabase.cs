using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace testPos
{
    class ClassConnectDatabase
    {
        public string strcon = "Data source=MSI\\SQLEXPRESS; initial catalog =mypos;integrated security=true";
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public void connectDatabase()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = strcon;
            conn.Open();
        }
    }
}
