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
            Game game = new Game();
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Inventory inventory1 = new Inventory();
            Inventory inventory2 = new Inventory();
            Store store = new Store();
            Weather weather1 = new Weather();
            Weather weather2 = new Weather();
            string action;

            Console.WriteLine("Introduciton:\n");
            game.Introduction();

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
            game.GetGameDuration();
            User_Interface.DisplayMessage(message: "Player1: " + player1.DisplayPlayerName() + "\tPlayer2: " + player2.DisplayPlayerName());  //Remove this line when done.
            int i = 0;
            while (game.daysPlayed > 0)
            {
                i++;
                User_Interface.ClearScreen();
                User_Interface.DisplayMessage("day: " + i);

                DateTime dt = DateTime.Now.AddDays(-game.daysPlayed);
                string strDate = dt.ToString("yyyyMMdd");
                User_Interface.DisplayMessage("\t Weather date is: " + strDate);
                weather1.DisplayWeather(strDate, player1.city, player1.state);
                player1.DisplayInventory();

                while (store.GoingToStore())
                {
                    action = store.EnterStore();
                    switch (action)
                    {
                        case "lemons":
                            store.BuyMoreLemons(player1);
                            break;
                        case "sugar":
                            store.BuyMoreSugar(player1);
                            break;
                        case "ice":
                            store.BuyMoreIce(player1);
                            break;
                        case "cups":
                            store.BuyMoreCups(player1);
                            break;
                    }

                }
                User_Interface.Wait();
                customer1.GetNumberOfCustomers(weather1.conds);
                customer1.GetPercentOfSales(Convert.ToInt32(weather1.maxtempi));
                User_Interface.Wait();


                game.daysPlayed -= 1;
            }
  

            string connectionString = "SERVER = desktop-ca2gle0; DATABASE = LemonadeStand; Integrated Security=true;";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            HighScore_tb.InsertPlayerScore("Todd", "2.67", sqlconn);
            HighScore_tb.GetTopTenScores(sqlconn);
            sqlconn.Close();
            User_Interface.Exit();

            
            
        }
    }
}
