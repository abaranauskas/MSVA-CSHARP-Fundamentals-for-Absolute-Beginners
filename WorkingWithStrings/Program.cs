using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";

            //string myString = "Cia yra bet koks stringas po bacslash ir n bus \nnauja eilute";

            //string myString = "o jei reikia naudoti bakslasha kazkur c:\\tai dvigubas backslashas";

            //string myString = @"arba reikia @ simbolio pries stringa ir tada \ ignoruos backslashus\";

            //string myString = String.Format("{0} = {0} != {1}", "Pirmas", "Antras");

            //string myString = String.Format("{0:C}", 123.25);

            //string myString = String.Format("{0:n}", 1234567890);

            //string myString = String.Format("{0:P}", .123);

            //string myString = String.Format("Phone number: {0:(#-###) ##-###}", 867847388);

            //string myString = "  cia bus bet    kox textas vnz     ";

            //myString = myString.Substring(6, 14); //pirmo simbolio indeksas o po kablelio ju skaicius
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6,5);  //pirmo simbolio indeksas o po kablelio ju skaicius
            //myString = myString.Trim();

            //myString = string.Format("ilgis before: {0} --- ilgis After: {1}", myString.Length, myString.Trim().Length);

            //string myString = "";

            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
            
                      

        }
    }
}
