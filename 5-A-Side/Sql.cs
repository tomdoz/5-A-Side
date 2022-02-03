//Cross-parameterised SQL methods that have queries passed into them to query against the database
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
        //Assigning the connection string to connect to the database
        public static SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        public static SqlCommand Com = new SqlCommand();
        public static SqlDataReader reader;

        public static void Insert(string command) //Insert new record into the database
        {
            Con.Open(); //opens the connection to the database
            Com.Connection = Con; 
            Com.CommandText = command; 
            Com.ExecuteNonQuery(); //Executes the command 
            Con.Close();
        }
        public static int Count(string table) //Uses the SQL Aggregate Function to Return the number of records in a table
        {
            Con.Open(); //Opens the connection to the database
            Com.Connection = Con;
            Com.CommandText = "Select COUNT(*) From " + table;
            int test = Convert.ToInt32(Com.ExecuteScalar()); //Executes the command
            Con.Close();
            return test;
        }

        public static string Select(string command, int readMultiplier, string targetColumn) //Select an attribute from a field in the table
        {
            Con.Open(); //Open connection to database
            Com.Connection = Con;
            Com.CommandText = command;
            reader = Com.ExecuteReader(); //Executes command
            for (int i = 0; i < readMultiplier + 1; i++) 
            {
                reader.Read(); //The reader moves down the number of records in the table specified by the readMultiplier
            }
            string output = Convert.ToString(reader[targetColumn]);
            reader.Close();
            Con.Close();
            return output; //returns the value selected from the table
        }

        public static void Update(string command) //Update an exisitng record in the table with new data
        {
            Con.Open(); //Open connection to database
            Com.Connection = Con;
            Com.CommandText = command;
            Com.ExecuteNonQuery(); //Executes the command
            Con.Close(); //Close connection
        }
    }
}
