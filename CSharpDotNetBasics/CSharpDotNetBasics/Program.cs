using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Program in Main Method because execution start at main method when u run the program :");
            Program m1=new Program();                 //Created an instance for program class.
            m1.method1();                             //by using object i called a method in Programming Class.
            Console.Beep();
        }


        public void method1()                       //method1 is created
        {
            Console.WriteLine("M1");
        }
        public void method2()                     //method1 is created
        {
            Console.WriteLine("M2");
        }
        public void method3()                    //method1 is created
        {
            Console.WriteLine("M3");
        }
    }
    class Wish                                    //another class is created
    {
        public void hello()
        {
            Console.WriteLine("HAi");
        }

    }

    
}
