using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class Functions
    {
        static void Main(string[] args)
        {
            squareRootNumber();

           int sum= Add(12,32);
            Console.WriteLine($"Sum of Two numbers By Using function :{sum}");
        }
        public static void squareRootNumber()
        {
            Console.Write("Enter a number for square root: ");
            int number = int.Parse(Console.ReadLine());
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"Square Root of {number} is {squareRoot}");
            Console.ReadLine();
        }
        static int Add(int a,int b)
        {
            
            return a + b;
        }
    }
}
