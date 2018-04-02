using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Player
    {
        // member variables
        string todd;
        public string name;
        public double wallet;
        public string city;
        public string state;

        // constructor
        public Player()
        {
            wallet = 5.00;
           
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
        public void GetLocation()
        {
            User_Interface.DisplayMessage("\nWhat city is your Lemonade Stand in?");
            city = User_Interface.GetUserInput();
            User_Interface.DisplayMessage("\nWhat state is your Lemonade Stand in?");
            state = User_Interface.GetUserInput();
        }

    }
}
