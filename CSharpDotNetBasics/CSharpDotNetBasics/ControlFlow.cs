using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class ControlFlow
    {
        public static void EvenOrOdd()                          //static mathod is created to check wheather the number is even or odd
        {
            Console.Write("enter a number :");  
            int num=Convert.ToInt32(Console.ReadLine());        //read number from keyboard
            if (num % 2== 0)
            {
                Console.WriteLine("Number is even. ");
            }
            Console.WriteLine("Number is odd. ");
        }
        static void Main(string[] args)
        {
            //int x = 2, y = 3;
            //var res = (x++) * (--y);
            //Console.WriteLine($"value of x: {x}\n value of y :{y}\n value of result :{res}");

            EvenOrOdd();                       //static method  is called
            if (10 > 8)
            {
                Console.WriteLine("Statement 1 :");
                Console.WriteLine("Statement 2 :");
                goto statement5;
            }
            else
            {
                                    //it will jump to the statement 5
                Console.WriteLine("Statement 3:");
                Console.WriteLine("Statement 4 :");
                Console.WriteLine("Statement 5 :");
           
            }
        statement5:
            Console.WriteLine("Statement 6 :");

            Console.ReadLine();

        }
    }
}
