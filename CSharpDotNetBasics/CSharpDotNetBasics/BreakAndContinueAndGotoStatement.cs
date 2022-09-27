using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class BreakAndContinueAndGotoStatement
    {
        static void Main(string[] args)
        {
            Continue();

            Goto();


           int num= 20;
            for(int i= 0; i < num; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                    break;
            }

        }

        public static void Continue()
        {
            for(int i = 1; i < 8; i++)
            {
                if (i == 5 )
                {
                    continue;
                }
                Console.WriteLine($"using Continue {i} \n");
            }
        }

        public static void Goto()
        {
            Console.WriteLine("1st Statement: ");
            Console.WriteLine("2nd Statement: ");
            goto statement5;
            Console.WriteLine("3rd Statement: ");
            Console.WriteLine("4th Statement: ");
            statement5:
            Console.WriteLine("5th Statement: ");
        }
    }
}
