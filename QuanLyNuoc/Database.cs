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

        //Bo dau
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        public static int GetId(string s)
        {
            int i = 0;
            while (!char.IsNumber(s[i]))
            {
                i++;
            }
            return int.Parse(s.Substring(i));
        }

        public static string GetNhanh(string s)
        {
            int i = 0;
            while (!char.IsNumber(s[i]))
            {
                i++;
            }
            return s.Substring(0, i);
        }
    }
}
