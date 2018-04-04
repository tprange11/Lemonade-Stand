using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Customer
    {
        // member variables
        public int customers = 0;
        public int percentSales = 0;
        // constructor
        public Customer()
        {

        }
        // member methods

        public void GetNumberOfCustomers(string weatherCondition)
        {
           Random rnd = new Random();
           
           switch (weatherCondition)
            {
                case "Clear":
                    customers = rnd.Next(200, 300);
                    break;

                case "Overcast":
                case "Partly Cloudy":
                case "Scattered Clouds":
                    customers = rnd.Next(1, 200);
                    break;

                case "Mostly Cloudy":
                case "Patches of Fog":
                case "Shallow Fog":
                case "Partial Fog":
                    customers = rnd.Next(1, 100);
                    break;

                case "Small Hail":
                case "Squalls":
                case "Funnel Cloud":
                case "Unknown Precipitation":
                case "Unknown":
                default:
                    customers = rnd.Next(1, 50);
                    break;
            }
            User_Interface.DisplayMessage("Number of customers: " + customers.ToString());

        }
        public void GetPercentOfSales(int weatherTemp)
        {
            Random rnd = new Random();

            if (weatherTemp > 90)
            {
                percentSales = rnd.Next(80, 100);
            } else if (weatherTemp > 80)
            {
                percentSales = rnd.Next(70, 90);
            }
            else if (weatherTemp > 80)
            {
                percentSales = rnd.Next(50, 70);
            } else
            {
                percentSales = rnd.Next(1, 50);
            }
            User_Interface.DisplayMessage("Percent of customers the bought: " + percentSales.ToString());

        }
    }
}
