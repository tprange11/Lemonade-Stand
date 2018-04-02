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
            

            Console.WriteLine("Introduciton:\n");
            Game game = new Game();
            game.Introduction();
            game.GetGameDuration();
            Player player1 = new Human();
            Player player2 = null;
            switch (Human.SelectOpponent().ToLower())
            {
                case "yes":
                    player2 = new Computer();
                    break;
                case "no":
                    player2 = new Human();
                    break;
                default:
                    break;
            }
            User_Interface.DisplayMessage(message: "Player1: " + player1.DisplayPlayerName() + "\tPlayer2: " + player2.DisplayPlayerName());  //Remove this line when done.
            int i = 0;
            while (game.daysPlayed > 0)
            {
                i++;
                User_Interface.DisplayMessage("day: " + i);

                DateTime dt = DateTime.Now.AddDays(-game.daysPlayed);
                String strDate = "";
                strDate = dt.ToString("yyyyMMdd");
                User_Interface.DisplayMessage("\t Weather date is: " + strDate);
                Weather.GetWeather(strDate, "Germantown", "WI");
                game.daysPlayed -= 1;
            }
  

            string connectionString = "SERVER = desktop-ca2gle0; DATABASE = LemonadeStand; Integrated Security=true;";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            HighScore_tb.InsertPlayerScore("Todd", "2.67", sqlconn);
            HighScore_tb.GetTopTenScores(sqlconn);
            sqlconn.Close();
            //Weather.GetWeather();
            User_Interface.GetUserInput();

            
            
        }
    }
}
