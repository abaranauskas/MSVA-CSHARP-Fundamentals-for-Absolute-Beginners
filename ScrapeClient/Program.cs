using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();

            string value = myScrape.ScrapeWebepage("http://estakada.lt");

            Console.WriteLine(value);
            Console.ReadLine(); 
        }
    }
}
