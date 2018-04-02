using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace LemonadeStand
{
    public static class Weather
    {
        public static void GetWeather(string date,string city, string state)
        {
            //Start program
            Console.WriteLine("Starting C# Weather Undeground Web API Test...");
            string wunderground_key = "df1e650266f41157"; // You'll need to goto http://www.wunderground.com/weather/api/, and get a key to use the API.

            parse("http://api.wunderground.com/api/" + wunderground_key + "/history_" + date + "/q/" + state + "/" + city + ".xml");

            // End.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private static void parse(string input_xml)
        {
            //Variables
            string maxtempi = "";
            string conds = "";

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

    }
    // member methods



}
