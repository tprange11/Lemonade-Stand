using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Player
    {
        // member variables
        public string name;
        public string city;
        public string state;
        Wallet wallet = new Wallet();
        Inventory inventory = new Inventory();
        Customer customer = new Customer();

        // constructor
        public Player()
        {
           
            wallet.TotalDollars = 20.00;
            
        }
        // member methods
        public virtual string DisplayPlayerName()
        {
            return name;
        }

        public virtual void SetPlayerName()
        {
            User_Interface.DisplayMessage("What is your name?\n");
            name = User_Interface.GetUserInput();
        }
        public virtual void GetLocation()
        {
            User_Interface.DisplayMessage("\nWhat city is your Lemonade Stand in?");
            city = User_Interface.GetUserInput();
            User_Interface.DisplayMessage("\nWhat state is your Lemonade Stand in?");
            state = User_Interface.GetUserInput();
        }
        public void UpdateWallet(double someNumber)
        {
            wallet.TotalDollars += someNumber;
        }
        public double GetWallet()
        {
            return wallet.TotalDollars;
        }
        public void AddLemons(int nbr)
        {
            inventory.AddLemons(nbr);
        }
        public void DisplayInventory()
        {
            inventory.DisplayInventory();
        }
    }
}
