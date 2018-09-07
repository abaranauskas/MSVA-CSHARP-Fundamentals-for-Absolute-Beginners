using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 1999;
            myCar.Color = "Silver";
            

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make,
                myCar.Model, myCar.Year, myCar.Color);

            //decimal value = DeterminateMarketValue(myCar);
            //Console.WriteLine("{0:c}", value);

            Console.WriteLine("{0:c}", myCar.DeterminateMarketValue());


            Console.ReadLine();

        }

        private static decimal DeterminateMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            

            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public int MyProperty { get; set; }



        public decimal DeterminateMarketValue()
        {
            decimal carValue;

            if (Year > 2000)
            {
                carValue = 1000;
            } else
            {
                carValue = 500;
            }

            return carValue;
        }
    }
}
