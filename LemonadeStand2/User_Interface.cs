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
        public static string GetUserKey()
        {
            string x = Console.ReadKey().Key.ToString();
            return x;
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }
        public static void Wait()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        public static void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
