using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables
        int lemons;
        int cups;
        int sugar;
        int ice;

        // constructor
        public Inventory()
        {
            lemons = 0;
            sugar = 0;
            ice = 0;
            cups = 0;
        }
        // member methods
        public void DisplayInventory()
        {
            User_Interface.DisplayMessage("\n***** SHOW INVENTORY *****");
            User_Interface.DisplayMessage("\tLemons:  " + lemons.ToString());
            User_Interface.DisplayMessage("\tSugar:  " + sugar.ToString());
            User_Interface.DisplayMessage("\tIce:  " + ice.ToString());
            User_Interface.DisplayMessage("\tCups:  " + cups.ToString());
            
            }
        public void AddLemons(int nbr)
        {
            lemons += nbr;
        }
        public void AddCups(int nbr)
        {
            cups += nbr;
        }
        public void AddSugar(int nbr)
        {
            sugar += nbr;
        }
        public void AddIce(int nbr)
        {
            ice += nbr;
        }
    }

}

