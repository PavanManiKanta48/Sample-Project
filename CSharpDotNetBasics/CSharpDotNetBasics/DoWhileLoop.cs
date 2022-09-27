using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class DoWhileLoop
    {

        static void Main(string[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            }
            while (num <= 5);

          Console.ReadLine();
        }
    }
}
