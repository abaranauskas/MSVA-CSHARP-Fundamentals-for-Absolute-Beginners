using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;

            //x = 7;
            //y = x + 3;

            //Console.WriteLine(y);
            //Console.ReadLine();

            Console.WriteLine("Whats your first name?");
            Console.Write("Type it: ");

            string fisrtName;
            fisrtName = Console.ReadLine();

            //string lastName;
            Console.Write("Now Tell me your Last name: ");
            //lastName = Console.ReadLine();
            string lastName = Console.ReadLine();

            Console.WriteLine("hello, " + fisrtName + " " + lastName);
            Console.ReadLine();

        }
    }
}
