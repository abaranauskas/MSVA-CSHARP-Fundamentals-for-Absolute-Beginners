using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\aidas\Desktop\WriteTexte.txt");
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!!");
                Console.WriteLine("Make sure the name of the file is named correctly: WriteText.txt");
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!!");
                Console.WriteLine("Make sure directories C:\\Users\aidas\\Desktop exist!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was a problem!!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Closing app now");
            }
            Console.ReadLine();


        }
    }
}
