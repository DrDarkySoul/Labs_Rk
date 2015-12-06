using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using HtmlAgilityPack;

namespace lab3._4
{
    class Program
    {
        static object locker = new object();
        public static string type = ".xml";
        public static string outputFile = "Output.txt";
        public static Dictionary<string, int> Cities = new Dictionary<string, int>()
        {
            {"Moscow", 4368},
            {"StPetersburg", 4079},
            {"Novosibirsk", 4690},
            {"Ekaterinburg", 4517},
            {"Novgorod", 4355},
            {"Kazan", 4364},
            {"Chelyabinsk", 4565},
            {"Omsk", 4578},
            {"Samara", 4618},
            {"RostovNaDonu", 5110}
        };
        static void Main(string[] args)
        {
            while (true)
            {
                foreach (var city in Cities)
                {
                    Task.Factory.StartNew(() => PrintCityTemp(city));
                }
                Thread.Sleep(7000);
                Console.Clear();
                DeleteFile();
            }
        }
        static void fileOut(string str)
        {
            lock (locker)
            {
                using (FileStream fs = new FileStream(outputFile, FileMode.OpenOrCreate))
                {
                    fs.Position = fs.Length;
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(str);
                        Thread.Sleep(500);
                    }
                }
            }
        }
        static void DeleteFile()
        {
            lock (locker)
            {
                File.Delete(outputFile);
            }
        }
        static void PrintCityTemp(KeyValuePair<string, int> city)
        {
            double cityTemp = 0;
            try
            {
                GetWebPage(city);
                cityTemp = ParseWebPage(city);
                fileOut(city.Key + " " + cityTemp + "C");
            }
            catch
            {
                Console.WriteLine("Error while processing " + city.Key);
                return;
            }
            Console.WriteLine("In " + city.Key + " temperature is " + cityTemp + "C");
        }
        static void GetWebPage(KeyValuePair<string, int> city)
        {
            string uri = String.Format("http://www.gismeteo.ru/city/daily/{0}/", city.Value);
            WebClient client = new WebClient();
            client.DownloadFile(new Uri(uri), city.Key + type);
        }
        static double ParseWebPage(KeyValuePair<string, int> city)
        {
            double cityTemp = 0;
            HtmlDocument htmlDoc = new HtmlDocument();

            htmlDoc.Load(city.Key + type);

            if (htmlDoc.DocumentNode != null)
            {
                HtmlNode bodyNode = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"weather\"]//div//div//div//dd//text()");
                if (bodyNode != null)
                {
                    string tempString = bodyNode.InnerText;
                    tempString = tempString.Replace("&minus;", "-");
                    cityTemp = Convert.ToDouble(tempString);
                }
            }

            return cityTemp;
        }
    }
}