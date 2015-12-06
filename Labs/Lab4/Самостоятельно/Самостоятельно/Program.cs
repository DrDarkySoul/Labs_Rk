using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.Threading;
using System.IO;

namespace Самостоятельно
{
    class Program
    {
        static object locker = new object();
        public static string type = ".xml";
        public static string outputFile = "Output.txt";
        public static Dictionary<string, string> Cities = new Dictionary<string, string>()
       { 
            {"First","FST"},
            {"Arch Coal Inc.","ACI"},
            {"SPDR S&P","SPY"},
            {"Apple","AAPL"},
            {"iShare Russell 2000","IWM"},
            {"Facebook","FB"},
            {"Tweeter","TWTR"},
            {"iShares MSCI","EEM"},
            {"PowerShares","QQQ"},
            {"Microsoft","MSFT"},
            {"Google","GOOG"}
        };
        static void Main(string[] args)
        {
            while (true)
            {
                foreach (var city in Cities)
                {
                    Task.Factory.StartNew(() => PrintCityTemp(city));
                }
                Thread.Sleep(12000);
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
        static void PrintCityTemp(KeyValuePair<string, string> city)
        {
            string cityTemp = "";
            try
            {
                GetWebPage(city);
                cityTemp = ParseWebPage(city);
                fileOut(city.Key + " " + cityTemp + "$");
            }
            catch
            {
                Console.WriteLine("Error while processing " + city.Key);
                return;
            }
            Console.WriteLine(city.Key + " " + cityTemp + "$");
        }
        static void GetWebPage(KeyValuePair<string, string> city)
        {
            string uri = String.Format("http://finance.yahoo.com/q?s={0}", city.Value);
            WebClient client = new WebClient();
            client.DownloadFile(new Uri(uri), city.Value + type);
        }
        static string ParseWebPage(KeyValuePair<string, string> city)
        {
            double cityTemp = 0;
            string tempString = "";
            HtmlDocument htmlDoc = new HtmlDocument();

            htmlDoc.Load(city.Value + type);

            if (htmlDoc.DocumentNode != null)
            {
                HtmlNode bodyNode = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"yfs_l84_" + (city.Value.ToLower()) + "\"]//text()");
                if (bodyNode != null)
                {
                    tempString = bodyNode.InnerText;
                }
            }
            return tempString;
        }
    }
}
