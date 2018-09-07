using MyCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScare = new Scrape();

            string value = myScare.ScrapeWebepage("http://estakada.lt");
            Console.WriteLine(value);


            Console.ReadLine();
        }
    }
}
