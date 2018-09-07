using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            
            
            DisplayResults(ReverseString(firstName), 
                ReverseString(lastName), ReverseString(city));

            Console.WriteLine();
            

            DisplayResults(String.Format("{0} {1} {2}", ReverseString(firstName),
                ReverseString(lastName), ReverseString(city)));

           
            
            Console.ReadLine();

        }

        private static string ReverseString(string mesage)
        {
            char[] mesageArray = mesage.ToCharArray();
            Array.Reverse(mesageArray);

            return String.Concat(mesageArray);
        }

        private static void DisplayResults(string revesedFirstName,
            string revesedLastName, string revesedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                revesedFirstName, revesedLastName, revesedCity));
        }

        private static void DisplayResults(string mesage)
        {
            Console.Write("Results: ");
            Console.Write(mesage);
        }
    }
}
