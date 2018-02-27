using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoClinica
{
    class connection
    {
        SqlConnection conn;
        String qrt = "Data Source=JUANC\\SQLEXPRESS;Initial";
        public SqlConnection DBConnection()
        {
            conn = new SqlConnection(qrt);
            conn.Open();
            return conn;
        }
    }
}
