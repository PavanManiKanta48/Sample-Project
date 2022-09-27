using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetBasics
{
    internal class Switch
    {

        static void Main(string[] args)
        {


            Console.Write("choose The day from 1 to 7 :  ");
            int day=Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                    default:                     
                    Console.WriteLine("Invalid number");
                    break ;

                    
            }
            OOPConcept();
        }
        public static void OOPConcept() //static class
        {
            string category;
            string topic = "Loops";
            switch (topic)
            {
                case "Introduction to C#":
                case "Variables":
                case "Data Types":
                    category = "Basic";
                    break;
                case "Loops":
                case "If ELSE Statements":
                case "Jump Statements":
                    category = "Control Flow";
                    break;
                case "Inheritance":
                case "Polymorphism":
                case "Abstraction":
                case "Encapsulation":
                    category = "OOPS Concept";
                    break;
                // default case 
                default:
                    category = "Invalid";
                    break;
            }
            Console.Write($"{topic} Category is {category}");
            Console.ReadKey();
        }
    }
}
