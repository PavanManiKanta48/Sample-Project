using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class StaticVariables2
    {
        static int x = 100; //Static Variable
        int y = 200; //Non-Static or Instance Variable
        public StaticVariables2(int a)
        {
            x = a;
            y = a;
        }
        public static void StaticBlock()
        {
            //By Default, every local variable is going to be static
            //The Scope is limited to this method only
            int y1 = 1000;
            Console.WriteLine(y1);
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(x);
            StaticVariables2 obj1 = new StaticVariables2(300);
            StaticBlock();
            Console.WriteLine(obj1.y);
            Console.WriteLine(x);
        }
    }
}
