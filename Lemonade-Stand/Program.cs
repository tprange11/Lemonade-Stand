using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string connectionString = "SERVER = desktop-ca2gle0; DATABASE = LemonadeStand; Integrated Security=true;";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            HighScore_tb.InsertPlayerScore("Todd", "2.67", sqlconn);
            HighScore_tb.GetTopTenScores(sqlconn);
            sqlconn.Close();
            Weather.GetWeather();
            User_Interface.GetUserInput();

            
            
        }
    }
}
