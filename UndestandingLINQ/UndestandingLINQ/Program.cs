using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndestandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Language integrated query

            List<Car> myCar = new List<Car>()
            {
                new Car() {VIN="A1", Make = "BMW", Model="740", StickerPrice=50000, Year=1999 },
                new Car() {VIN="B1", Make = "AUDI", Model="100", StickerPrice=75000, Year=1987 },
                new Car() {VIN="C1", Make = "BMW", Model="190", StickerPrice=25000, Year=2010 },
                new Car() {VIN="D1", Make = "MG", Model="rga", StickerPrice=35000, Year=2004 },
                new Car() {VIN="E1", Make = "BMW", Model="Veyron", StickerPrice=150000, Year=2000 }
            };

            //LINQ query syntax
            /*var bmw = from car in myCar
                      where car.Make == "BMW"
                      && car.Year == 2016
                      select car;*/

            /*var orderCars = from car in myCar
                            orderby car.Year descending
                            select car;*/


            //LINQ methods syntax
            var bmw = myCar.Where(k => k.Make == "BMW" && k.Year==2016);
            var orderCars = myCar.OrderByDescending(k => k.Year); //mazejimo tvarka surusiuos sarasa ir priskirs kintamajam

            var firstItem = myCar.First(k => k.Make=="BMW"); //Cia ras pirma sarase pagal nurodyta salyga
            var firstItemOrdered = myCar.OrderByDescending(p =>p.Year).First(k => k.Make == "BMW"); //Galima chaninti 
            //pirmiasuia susortins o tada paims pirma

            Console.WriteLine(myCar.TrueForAll(p => p.Year>1980)); // returnina tru arba false pagal salyga turi but visi automobiliai naujasni uz 1980 kad butu true

            myCar.ForEach(p => p.StickerPrice -= 3000); //sumazins visu sticker price per 3000
            myCar.ForEach(p => Console.WriteLine("{0} {1:c}", p.VIN, p.StickerPrice)); //perduodamas objektas is ir konsilinama tik nurodyti 

            Console.WriteLine(myCar.Exists(p => p.Model=="Veyron")); //exists returnina trua arba false
            Console.WriteLine("{0:c}", myCar.Sum(p=> p.StickerPrice)); //returnins suma


            Console.WriteLine(firstItem.VIN);
            Console.WriteLine(firstItemOrdered.VIN);

            Console.WriteLine(myCar.GetType());
            Console.WriteLine(orderCars.GetType());
            Console.WriteLine(bmw.GetType());

            var newCars = from car in myCar
                      where car.Make == "BMW"
                      && car.Year == 2016
                      select new {car.Make, car.Model };

            Console.WriteLine(newCars.GetType());


            foreach (var car in orderCars)
            {
                //Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year );
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
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
