using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace LemonadeStand
{
    public class Weather
    {
        public string maxtempi = "";
        public string conds = "";
        public Weather()
        {

        }
        public void DisplayWeather(string date, string city, string state)
        {
            //Start program
            string wunderground_key = "df1e650266f41157"; // You'll need to goto http://www.wunderground.com/weather/api/, and get a key to use the API.

            Parse("http://api.wunderground.com/api/" + wunderground_key + "/history_" + date + "/q/" + state + "/" + city + ".xml");

            // End.

        }
        public string GetWeatherCondition(string date, string city, string state)
        {
            //Start program
            string condition;
            string wunderground_key = "df1e650266f41157"; // You'll need to goto http://www.wunderground.com/weather/api/, and get a key to use the API.

            condition = ParseWeatherCondition("http://api.wunderground.com/api/" + wunderground_key + "/history_" + date + "/q/" + state + "/" + city + ".xml");

            return condition;
        }
        public string GetWeatherTemp(string date, string city, string state)
        {
            //Start program
            string temp;
            string wunderground_key = "df1e650266f41157"; // You'll need to goto http://www.wunderground.com/weather/api/, and get a key to use the API.

            temp = ParseWeatherTemp("http://api.wunderground.com/api/" + wunderground_key + "/history_" + date + "/q/" + state + "/" + city + ".xml");

            return temp;
        }
        private void Parse(string input_xml)
        {
            var cli = new WebClient();
            string weather = cli.DownloadString(input_xml);

            using (XmlReader reader = XmlReader.Create(new StringReader(weather)))
            {
                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name.Equals("maxtempi"))
                            {
                                reader.Read();
                                maxtempi = reader.Value;
                            }
                            else if (reader.Name.Equals("conds"))
                            {
                                reader.Read();
                                conds = reader.Value;
                            }

                            break;
                    }
                }
            }
            Console.WriteLine("********************");
            Console.WriteLine("High Temp:           " + maxtempi);
            Console.WriteLine("Conditions:       " + conds);


        }
        private string ParseWeatherCondition(string input_xml)
        {
            var cli = new WebClient();
            string weather = cli.DownloadString(input_xml);

            using (XmlReader reader = XmlReader.Create(new StringReader(weather)))
            {
                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name.Equals("conds"))
                            {
                                reader.Read();
                                conds = reader.Value;
                            }

                            break;
                    }
                }
            }
            return conds;
        }
        private string ParseWeatherTemp(string input_xml)
        {
            var cli = new WebClient();
            string weather = cli.DownloadString(input_xml);

            using (XmlReader reader = XmlReader.Create(new StringReader(weather)))
            {
                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name.Equals("maxtempi"))
                            {
                                reader.Read();
                                maxtempi = reader.Value;
                            }
                            break;
                    }
                }
            }
            return maxtempi;
        }
 

    }
    // member methods



}
