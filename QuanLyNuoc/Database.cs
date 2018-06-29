using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNuoc
{
    class Database
    {
        public static string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNuoc;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connStr);

        public static SqlDataReader Read(string query)
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteReader();
        }
    }
}
