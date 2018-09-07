using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            // Example #2: Write one string to a text file.
            string text = "Aidas Baranauskas";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            File.WriteAllText(@"C:\Users\aidas\Desktop\WriteText.txt", text);


            WebClient client = new WebClient();
            string reply = client.DownloadString("http://estakada.lt");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\aidas\Desktop\WriteText.txt", reply);


            Console.WriteLine("Hello Aidas!");
            Console.ReadLine();
        }
    }
}
