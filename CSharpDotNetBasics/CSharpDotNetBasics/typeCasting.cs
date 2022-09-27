using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class typeCasting
    {

        public void ImplicitCasting()                     //Implicit Type Casting
        {
            int num = 123;
            double number = num;
            long l=num;
            Console.WriteLine($"iMPLICIT CASTING : int to double{number}, int to long{l} \n ");
        }
        public void ExplicitCasting()                       //Explicit Type Casting
        {
                double d = 125.4;
                int Cnum = (int)d;
                float f = 1234.56f;
                int i = (int)f;
                byte b = (byte)f;
                //string str = "pavan";
                //int toint = Convert.ToInt32(str);        //Cannot convert string to int
                Console.WriteLine($"EXPLICIT CASTING Double:{Cnum}, float to int :{i} \n ");
                Console.WriteLine($"Before Conversoin value is :{f} after Conveersion Value is :{b}");
               // Console.WriteLine($"Before Conversoin value is :{str} after Conveersion Value is :{toint}");  
                       
           
        }
        static void Main(string[] args)
        {
            typeCasting tc = new typeCasting();
            tc.ImplicitCasting();
            tc.ExplicitCasting();
            Console.ReadLine();
        }
    }
}
