using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
     class DataTypes
    {
        static void Main()
        {
            string str = "Pavan";
            var HMbytes=str.Length*sizeof(char);
            int num = 120000;
            bool flag = false;
            char c = 'p';
            double d = 12314.55;
            decimal dec = 12334.34m;
            float f = 1234.00f;

            Console.WriteLine($"string {str},\n Integer {num},\n Boolean {flag},\n character {c},\n double{d},\n Decimal{dec},\n float{f},\nHow many bytes {HMbytes}");
        }
    }
}
