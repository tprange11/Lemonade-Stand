using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Store
    {
        // member variables
        decimal lemonPrice;
        decimal sugarPrice;
        decimal cupsPrice;
        decimal icePrice;
        decimal wallet;

        // constructor
        public Store()
        {
            lemonPrice = 0.10m;
            sugarPrice = 0.10m;
            cupsPrice = 0.10m;
            icePrice = 0.10m;

        }
        // member methods
        public bool GoingToStore()
        {
            bool result = false;
            string answer;
            User_Interface.DisplayMessage("Do you need items from the store?");
            answer = User_Interface.GetUserInput();
            if (answer == "yes")
            {
                result = true;
            }
            else if (answer == "no")
            {
                result = false;
            }
            else
            {
                User_Interface.DisplayMessage("Please enter \"yes\" or \"no\".");
                GoingToStore();
            }
            return result;

        }
        public string EnterStore()
        {
            string action = "continue";
            User_Interface.ClearScreen();
            User_Interface.DisplayMessage("Welcome to WALMART!  Get your SHIT and get OUT!\n");
            User_Interface.DisplayMessage("               Inventory/Purchase              ");
            User_Interface.DisplayMessage(" Lemons                          Press 1 to buy");
            User_Interface.DisplayMessage(" Cups of Sugar                   Press 2 to buy");
            User_Interface.DisplayMessage(" Ice Cubes                       Press 3 to buy");
            User_Interface.DisplayMessage(" Paper Cups                      Press 4 to buy");
            
            switch (User_Interface.GetUserKey())
            {
                case "D1":
                    action = "lemons";
                    break;
                case "D2":
                    action = "sugar";
                    break;
                case "D3":
                    action = "ice";
                    break;
                case "D4":
                    action = "cups";
                    break;
                default:
                    User_Interface.DisplayMessage("Please enter \"1\",\"2\",\"3\" or \"4\".");
                    EnterStore();
                    break;
            }
            return action;
        }
        public void BuyMoreLemons(Player player)
        {
            User_Interface.DisplayMessage("25 Lemmons for 0.89\tPress \"1\" to buy");
            User_Interface.DisplayMessage("50 Lemmons for 1.74\tPress \"2\" to buy");
            User_Interface.DisplayMessage("100 Lemmons for 3.20\tPress \"3\" to buy");
            switch (User_Interface.GetUserKey())
            {
                case "D1":
                    if (player.GetWallet() >= 0.89)
                    {
                        player.UpdateWallet(-0.89);
                        
                    }
                    break;
                case "D2":
                    if (player.GetWallet() >= 1.74)
                    {
                        player.UpdateWallet(-1.74);
                    }
                    break;
                case "D3":
                    if (player.GetWallet() >= 3.20)
                    {
                        player.UpdateWallet(-3.20);
                    }
                    break;
                default:
                    User_Interface.DisplayMessage("Please enter \"1\",\"2\" or \"3\".");
                    EnterStore();
                    break;
            }
        }
        public void BuyMoreSugar(Player player)
        {
            User_Interface.DisplayMessage("25 Cups of Sugar for 0.89\tPress \"1\" to buy");
            User_Interface.DisplayMessage("50 Cups of Sugar for 1.74\tPress \"2\" to buy");
            User_Interface.DisplayMessage("100 Cups of Sugar for 3.20\tPress \"3\" to buy");
            switch (User_Interface.GetUserKey())
            {
                case "D1":
                    if (player.GetWallet() >= 0.89)
                    {
                        player.UpdateWallet(-0.89);

                    }
                    break;
                case "D2":
                    if (player.GetWallet() >= 1.74)
                    {
                        player.UpdateWallet(-1.74);
                    }
                    break;
                case "D3":
                    if (player.GetWallet() >= 3.20)
                    {
                        player.UpdateWallet(-3.20);
                    }
                    break;
                default:
                    User_Interface.DisplayMessage("Please enter \"1\",\"2\" or \"3\".");
                    EnterStore();
                    break;
            }
        }
        public void BuyMoreIce(Player player)
        {
            User_Interface.DisplayMessage("25 Ice Cubes for 0.89\tPress \"1\" to buy");
            User_Interface.DisplayMessage("50 Ice Cubes for 1.74\tPress \"2\" to buy");
            User_Interface.DisplayMessage("100 Ice Cubes for 3.20\tPress \"3\" to buy");
            switch (User_Interface.GetUserKey())
            {
                case "D1":
                    if (player.GetWallet() >= 0.89)
                    {
                        player.UpdateWallet(-0.89);

                    }
                    break;
                case "D2":
                    if (player.GetWallet() >= 1.74)
                    {
                        player.UpdateWallet(-1.74);
                    }
                    break;
                case "D3":
                    if (player.GetWallet() >= 3.20)
                    {
                        player.UpdateWallet(-3.20);
                    }
                    break;
                default:
                    User_Interface.DisplayMessage("Please enter \"1\",\"2\" or \"3\".");
                    EnterStore();
                    break;
            }

        }
        public void BuyMoreCups(Player player)
        {
            User_Interface.DisplayMessage("25 Paper Cups for 0.89\tPress \"1\" to buy");
            User_Interface.DisplayMessage("50 Paper Cups for 1.74\tPress \"2\" to buy");
            User_Interface.DisplayMessage("100 Paper Cups for 3.20\tPress \"3\" to buy");
            switch (User_Interface.GetUserKey())
            {
                case "D1":
                    if (player.GetWallet() >= 0.89)
                    {
                        player.UpdateWallet(-0.89);

                    }
                    break;
                case "D2":
                    if (player.GetWallet() >= 1.74)
                    {
                        player.UpdateWallet(-1.74);
                    }
                    break;
                case "D3":
                    if (player.GetWallet() >= 3.20)
                    {
                        player.UpdateWallet(-3.20);
                    }
                    break;
                default:
                    User_Interface.DisplayMessage("Please enter \"1\",\"2\" or \"3\".");
                    EnterStore();
                    break;
            }
        }
        public void BuyItems()
        {

        }
    }
}
