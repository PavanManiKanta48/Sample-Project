using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            forLoop();
            FibanaciSeriesUsingWhileLoop();
            Console.ReadLine();
        }
        public static void forLoop()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void FibanaciSeriesUsingWhileLoop()
        {
            int i, n, j, k;
            Console.Write("Enter a Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            j = 1;
            Console.Write($"{i} {j}");

            k = i + j;
            while (k <= n)
            {
                Console.Write($" {k}");

                i = j;
                j = k;
                k = i + j;
            }

        }
    }
}
