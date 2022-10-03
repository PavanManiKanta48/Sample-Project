using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class ImplementationClass : ITestInterface1
    {
        public void Add(int a, int b)             //Interface Method Implementation
        {
            Console.WriteLine($"Sum Of {a} and {b} is :{a + b}" );
        }
        void ITestInterface1.Sub(int a, int b)     //This method purely belongs to ImplementationClass
        {
            Console.WriteLine($"Sub Of {a} and {b} is :{a - b}");
        }
    }
}
    

