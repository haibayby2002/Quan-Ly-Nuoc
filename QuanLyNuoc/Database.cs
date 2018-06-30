using System;
using System.Collections.Generic;
using System.Data;
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
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteReader();
        }

        //Return data table
        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(connStr);
            SqlCommand cm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }

        //insert, update, delete
        static public int Change(string sql)
        {
            conn = new SqlConnection(connStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cm = new SqlCommand(sql, conn);
            int kq = cm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
    }
}
