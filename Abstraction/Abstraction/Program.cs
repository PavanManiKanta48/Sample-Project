using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Benz benzObj = new Benz();
            benzObj.carSound();
            benzObj.color();
            Console.ReadLine();


            /*implementing an abstraction functionality by allowing only a few properties and methods to access outside of the class */
            Laptop laptop = new Laptop();
            laptop.Brand = "Dell";
            laptop.Model = "Inspiron 14R";
            laptop.LaptopDetails();
            Console.WriteLine("\n Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
