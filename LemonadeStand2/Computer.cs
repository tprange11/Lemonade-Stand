using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Computer : Player
    {
        // member variables


        // constructor
        public Computer()
        {
            SetPlayerName();
            GetLocation();
            Weather weather = new Weather();

        }
        // member methods
        public override void SetPlayerName()
        {
            name = "Sophia";
        }
        public override void GetLocation()
        {
            User_Interface.DisplayMessage("\nWhat city will Sophia's Lemonade Stand in?");
            city = User_Interface.GetUserInput();
            User_Interface.DisplayMessage("\nWhat state will Sophia's Lemonade Stand in?");
            state = User_Interface.GetUserInput();
        }

    }
}
