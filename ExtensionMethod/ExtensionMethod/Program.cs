using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 123456;
            float result = num1.GetDigits();
            Console.WriteLine("Digits :" + result);
        }
    }
}
