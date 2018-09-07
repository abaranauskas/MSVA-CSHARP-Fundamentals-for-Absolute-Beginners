using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Focus";
            car1.VIN = "123456";

            Car car2 = new Car();
            car2.Make = "Dodge";
            car2.Model = "Ram";
            car2.VIN = "321654";

            Book b1 = new Book();
            b1.Title = "Microsoft .NET";
            b1.Athor = "Robet Tabor";
            b1.ISBN = "0-000-0000-0";

            ////Array list. dinamiskai sizinimas. priesingai nei array. sortinimas , removinimas/
            //bet cia galima ideti skirtingus tipus del to geriau list
            //ArrayList myArrayList = new ArrayList();

            //myArrayList.Add(car1);
            //myArrayList.Add(car2);
            //myArrayList.Add(b1);
            //myArrayList.Remove(b1);

            //foreach (Car car in myArrayList)
            //{
            //    Console.WriteLine(car.Make);
            //}


            //List<data tipe> vardas = new List<data tipe>();
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);
            
            foreach (Car car in myList)
            {
                //Console.WriteLine(car.Model);
            }

            //Dictionaty<Data type of Tkey, Tvalue> vardas;
            Dictionary<string, Car > myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["321654"].Make);

            string[] vardas = new string[5];

            //--------------------------
            //string[] vardas = new string[5];
            //string[] names = { "Robas", "Aidas", "Bobas", "Danas" }; //array sukurimas be new. is kart duomenys sudedami

            //Object initializer syntax
            //nereikia konstruktoriaus
            Car car3 = new Car() {Make = "BMW", Model = "750M", VIN = "777" };
            Car car4 = new Car() { Make = "MB", Model = "63", VIN = "888" };

            //Colection initializer
            List<Car> myList2 = new List<Car>() {
                car3,
                car4,
                new Car() {Make = "Fiat", Model = "500", VIN = "111"  },
                new Car() {Make = "Subaru", Model = "Outback", VIN = "222"  }
            };

            foreach (Car car in myList2)
            {
                Console.WriteLine(car.Make);
            }

            //Console.WriteLine();

            Console.ReadLine();
        }
    }

    class Car   
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Athor { get; set; }
        public string ISBN { get; set; }
    }
}
