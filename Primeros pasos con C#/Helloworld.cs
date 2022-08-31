using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Primera parte: Impresión en consola");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Segunda parte: uso de write() y writeland()");
            // Console.WriteLine("Hello World!");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Congratulations! ");
            Console.WriteLine("You wrote your first lines of code!");
            Console.WriteLine("");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Desafio");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("This is ");
            Console.WriteLine("the first line");

            Console.WriteLine("This is the second line");
            Console.WriteLine("");
            Console.WriteLine("ENTER para salir de la consola");

            Console.Read();
        }
    }
}

