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
        public static SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        public static SqlCommand Com = new SqlCommand();
        public static SqlDataReader reader;

        public static void Insert(string command)
        {
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = command;
            Com.ExecuteNonQuery();
            Con.Close();
        }
        public static int Count(string table)
        {
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = "Select COUNT(*) From " + table;
            int test = Convert.ToInt32(Com.ExecuteScalar());
            Con.Close();
            return test;
        }

        public static string Select(string command, int readMultiplier, string targetColumn)
        {
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = command;
            reader = Com.ExecuteReader();
            for (int i = 0; i < readMultiplier + 1; i++)
            {
                reader.Read();
            }
            string output = Convert.ToString(reader[targetColumn]);
            reader.Close();
            Con.Close();
            return output;
        }

        public static void Update(string command)
        {
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = command;
            Com.ExecuteNonQuery();
            Con.Close();
        }

        public static int CountRows(string table)
        {
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = ("Select * from " + table);
            reader = Com.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            Con.Close();
            return count;
        }
    }
}
