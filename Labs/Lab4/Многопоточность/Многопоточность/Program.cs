using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace Многопоточность
{
    class Program
    {
        static void GetWebPage()
        {
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(new Uri("https://www.gismeteo.ru/city/daily/4368/"), @"C:\Users\Ришат\Desktop\Папка\C#\Lab4\Многопоточность\Moscow.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Thread getWeatherThread = new Thread(GetWebPage);
            getWeatherThread.Start();
            while(true)
            {
                if (getWeatherThread.IsAlive)
                {
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                    }
                    else
                    {
                        stopwatch.Stop();
                        break;
                    }
                }
            }
            Console.WriteLine("Page download for " + (Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000) + " sec.");
            Console.ReadKey();
        }
    }
}
