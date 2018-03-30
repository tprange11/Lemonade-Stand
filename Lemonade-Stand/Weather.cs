using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LemonadeStand
{
    public static class Weather
    {
        public static void GetWeather()
        {
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/forecast?q=Milwaukee&appid=97e75e23779deb19bb9b1ecc5b58f445");
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            User_Interface.DisplayMessage(responseFromServer);
            //dynamic stuff = JsonConvert.DeserializeObject(responseFromServer);
            // Clean up the streams and the response.  
            reader.Close();
            response.Close();
        }

    }
    // member methods



}
