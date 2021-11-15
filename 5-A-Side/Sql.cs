using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _5_A_Side
{
    public class Sql
    {
        public static void SqlInsert(string command, string Connection)
        {
            SqlConnection Con = new SqlConnection(@Connection);
            SqlCommand Com = new SqlCommand();
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = command;
            Com.ExecuteNonQuery();
        }
        public static void SqlSelect(string command, string Connection)
        {
            SqlConnection Con = new SqlConnection(@Connection);
            SqlCommand Com = new SqlCommand();
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = command;
            SqlDataReader reader = Com.ExecuteReader();
        }
    }
}
