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
        }
        // member methods
        public override void SetPlayerName()
        {
            name = "Sophia";
        }

    }
}
