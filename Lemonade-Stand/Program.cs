using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string connectionString = "SERVER = localhost, DATABASE = SBM";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            
            
        }
    }
}
