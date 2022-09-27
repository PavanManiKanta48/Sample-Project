using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class ForLoop
    {
        static void Main(string[] args)
        {
            CustomIfStatementInsideForlLoop();    //calling the static method

            Console.Write("Enter one Integer Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i= 1; i < number; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }




        public static void CustomIfStatementInsideForlLoop()
        {
            Console.Write("Enter one Integer Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            for(; ; )
            {
                Console.WriteLine(i);
                i++;
                if(i>number)
                    break;
            }
        }
    }
}
