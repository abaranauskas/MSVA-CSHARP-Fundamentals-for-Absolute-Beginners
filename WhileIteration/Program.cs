using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose option!");
            Console.WriteLine("1) option 1");
            Console.WriteLine("2) option 2");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();

            if (result == "1")
            {
                Wawa();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private static void Wawa()
        {
            Console.Clear();
            Console.WriteLine("Wa taip");
            Console.Write("Type Number:");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= result)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();

        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 1;
            bool incorrect = true;

            Console.WriteLine("Ivesk sk nuo 1 iki 10");
            int sk = int.Parse(Console.ReadLine());

            do
            {
                
                if (sk == randomNumber)
                {
                    incorrect = false;
                }
                else
                {
                    guesses++;
                    Console.WriteLine("Wrong!");
                    Console.WriteLine("spek dar kart");
                    sk = int.Parse(Console.ReadLine());
                }
            } while (incorrect && guesses<3);

            if (incorrect)
            {
                Console.WriteLine("Deja neatspeja per 3 kart");
            }
            else
            {
                Console.WriteLine("Correct! it took you {0} times", guesses);
            }

            Console.ReadLine();
        }
    }
}
