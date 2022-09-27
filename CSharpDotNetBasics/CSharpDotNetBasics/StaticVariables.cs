using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class StaticVariables
    {
        static int num =100;      //Static Variable
        static string str = "Pavan"; //Static Variable
        string name = "Pavan manikanta";   //Non-Static or Instance Variable
        public StaticVariables(string name1)
        {
            name = name1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Number is: {num}, \n string was :{str}");
            StaticVariables sv = new StaticVariables("pavan is calling Constructor1 :");
            StaticVariables sv1 = new StaticVariables("pavan Mnikanta is calling Constructor2 :");
            Console.WriteLine($"{sv.name}\n {sv.name}"); //reference is required for non static field 
        }
    }
}
