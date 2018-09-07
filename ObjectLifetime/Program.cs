using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLifetime;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();


            //myCar.Make = "Ford";
            //myCar.Model = "Focus";
            //myCar.Year = 1999;
            //myCar.Color = "silver";

            Car myOtherCar;

            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",myOtherCar.Make,
                myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "Mondeo";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make,
                myCar.Model, myCar.Year, myCar.Color);

            myOtherCar = null; //reference panaikinimas

            //Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make,
            // myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            //myCar = null;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Console.ReadLine();

            
        }
    }

    class Car
    {
        public Car()
        {
            this.Make = "Nissan";  //this key optional rodo i objecta
        }

        public Car(string make, string model, int year, string color)  //overloaded ctor
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;

        }

        public static void MyMethod()
        {
            Console.WriteLine("Called static myMethod");
            //Console.WriteLine(Make);
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
