using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Передача_параметров_в_поток
{
    public struct Cities
    {
        public static KeyValuePair<string, string> Moscow = new KeyValuePair<string, string>("Moscow", "4368");
        public static KeyValuePair<string, string> StPetersburg = new KeyValuePair<string, string>("StPetersburg", "4079");
        public static KeyValuePair<string, string> Novosibirsk = new KeyValuePair<string, string>("Novosibirsk", "4692");
        public static KeyValuePair<string, string> Ekaterinburg = new KeyValuePair<string, string>("Ekaterinburg", "4517");
        public static KeyValuePair<string, string> Novgorod = new KeyValuePair<string, string>("Novgorod", "4355");
        public static KeyValuePair<string, string> Kazan = new KeyValuePair<string, string>("Kazan", "4364");
        public static KeyValuePair<string, string> Chelyabinsk = new KeyValuePair<string, string>("Chelyabinsk", "4565");
        public static KeyValuePair<string, string> Omsk = new KeyValuePair<string, string>("Omsk", "4578");
        public static KeyValuePair<string, string> Samara = new KeyValuePair<string, string>("Samara", "4618");
        public static KeyValuePair<string, string> RostovNaDonu = new KeyValuePair<string, string>("RostovNaDonu", "51110");
    }
    class Program
    {
        static void Main(string[] args)
        {
            string url = string.Format("https://www.gismeteo.ru/city/daily/{0}/", Cities.Moscow.Value);
            Stopwatch stopwatch = new Stopwatch();
            Thread getWeatherThread = new Thread(() => GetWebPage(url, Cities.Moscow.Key));
            getWeatherThread.Start();
            do
            {
                if (getWeatherThread.IsAlive)
                {
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                    }
                }
                else
                {
                    stopwatch.Stop();
                    break;
                }
            } while (true);
            Console.WriteLine("Page downloaded for " + Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000 + " sec");
            Console.ReadKey();
        }

        static void GetWebPage(string url, string localFileName)
        {
            WebClient client = new WebClient();
            client.DownloadFile(new Uri(url), localFileName + ".txt");
        }
    }
}
