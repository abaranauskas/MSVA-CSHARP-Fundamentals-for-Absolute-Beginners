using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            //for (int i = 0; i < numbers.Length;  i++)
            //{
            //    if (numbers[i] == 16)
            //    {
            //        Console.WriteLine("radau {0}", numbers[i]);
            //    }
            //}
            //Console.WriteLine(numbers.Length);
            //Console.ReadLine();

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42};

            //string[] names = new string[] { "edddie", "alex", "jow", "leo" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            // Console.ReadLine();

            string zig = "You can get what you want out of life" +
                " if you help enough other peaople get what they want!";

            char[] charMasyvas = zig.ToCharArray();

            Console.WriteLine("Origina: {0}", zig);
            Console.Write("Reversed: ");

            //for (int i = charMasyvas.Length-1; i >= 0; i--)
            //{
            //    Console.Write(charMasyvas[i]);
            //}

            Array.Reverse(charMasyvas);

            foreach (char simbolis in charMasyvas)
            {
                Console.Write(simbolis);
            }

            Console.ReadLine();
        }
    }
}
