using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LemonadeStand
{
    class HighScore_tb
    {
        // member variables

        // constructor
        public HighScore_tb()
        {

        }
        // member methods
        public static void InsertPlayerScore(string name, string score, SqlConnection sqlconn)
        {
            String query = "INSERT INTO dbo.HighScore(name,score) VALUES (@name,@score)";
            using (SqlCommand command = new SqlCommand(query, sqlconn))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@score", score);
                int result = command.ExecuteNonQuery();
                // Check Error
                if (result < 0)
                {
                    Console.WriteLine("Error inserting data into Database!");
                }
            }
        }
        public static void GetTopTenScores(SqlConnection sqlconn)
        {
            List<String> columnData = new List<String>();
            String query = "SELECT TOP(10) name,score FROM LemonadeStand.dbo.HighScore ORDER BY score DESC";
            using (SqlCommand command = new SqlCommand(query, sqlconn))
            {
                int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //List<T> list = new List<T>();
                    //T obj = default(T);
                    //while (reader.Read())
                    //{
                    //    obj = Activator.CreateInstance<T>();
                    //    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    //    {
                    //        if (!object.Equals(dr[prop.Name], DBNull.Value))
                    //        {
                    //            prop.SetValue(obj, dr[prop.Name], null);
                    //        }
                    //    }
                    //    list.Add(obj);
                    //}
                }
                //var query1 = from data in sqlconn.HighScore
                //            where tbl.PlatypusID == yourPlatypusID
                //                   && tbl.Id > lastIDToIgnore
                //            select new
                //            {
                //                tbl.DuckbillName,
                //                tbl.Swamp
                //            };
                // Check Error
                if (result < 0)
                {
                    Console.WriteLine("Error reading data from Database!");
                }
            }
        }
    }
}
