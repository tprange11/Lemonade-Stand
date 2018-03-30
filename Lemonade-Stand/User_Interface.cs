using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public static class User_Interface
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
