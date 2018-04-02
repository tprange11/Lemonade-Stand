using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Human : Player
    {
        // member variables

        // constructor
        public Human()
        {
            SetPlayerName();

        }
        // member methods
        public override void SetPlayerName()
        {
            User_Interface.DisplayMessage("What is your name?\n");
            name = User_Interface.GetUserInput();
        }
        public static string SelectOpponent()
        {
            string response;
            User_Interface.DisplayMessage("Would you like to play the computer?");
            response = User_Interface.GetUserInput();
            return response;

        }

    }
}
