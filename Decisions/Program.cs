using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Bobs Big give away");
            //Console.WriteLine("Choose a door: 1, 2 or 3");

            //string userValue = Console.ReadLine();
            //string message;

            //if (userValue == "1")
            //{
            //    message = "you won new car";
            //}

            //else if (userValue == "2")
            //{
            //    message = "you won new cat";

            //}
            //else if (userValue == "3")
            //{
            //    message = "you won new boat";
            //}
            //else
            //{
            //    message = "you lost";

            //}
            //Console.WriteLine(message);
            //Console.ReadLine();


            Console.WriteLine("Bobs Big give away");
            Console.WriteLine("Choose a door: 1, 2 or 3");

            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "Boat" : "Strand of lint";
            Console.WriteLine("you won {0}.",message);
            Console.ReadLine();


        }
    }
}
