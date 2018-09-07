using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString()); // tiksli data ir tikslu laikas

            //Console.WriteLine(myValue.ToShortDateString()); //tik tikslidata

            //Console.WriteLine(myValue.ToShortTimeString());  //tik valandos ir minutes

            //Console.WriteLine(myValue.ToLongDateString()); // data kai menesis zodis

            //Console.WriteLine(myValue.ToLongTimeString()); //tiiklus laikas iki sekundziu

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());  //cia taip atimti dienas

            //Console.WriteLine(myValue.Month); //returnina skaiciu menesio

            DateTime myBDay = new DateTime(1987, 5, 8);  //taip sukuremas datos objektas

            Console.WriteLine(myBDay.ToShortDateString());

            DateTime manoGimtadienis = DateTime.Parse("05/08/1986");

            Console.WriteLine(manoGimtadienis.ToShortDateString());

            TimeSpan myAge = DateTime.Now.Subtract(myBDay);

            Console.WriteLine(myAge.TotalDays);




            Console.ReadLine();
        }
    }
}
