
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImplementationClass implementationClass = new ImplementationClass();
            implementationClass.Add(12, 32);                      //Using obj1 we can call the Add method directly because It is implemented using public access specifier
          
            ((ITestInterface1)implementationClass).Sub(234, 34);  //We need to typecast obj1 to ITestInterface1 to call the Sub method because Sub method is implemented using Interface name

            
            ITestInterface1 I1 = new ImplementationClass();       //We can call the method directly using the interface reference
                                                                  //Typecasting is not required in this case

            I1.Add(10, 20);
            I1.Sub(34, 54);
            Console.ReadLine();  

            //Here we are creating Objects for fish, hawk,rabbit
           
            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Console.ReadLine();

            Hawk hawk = new Hawk();
            hawk.Hunt();
            Console.ReadLine();

            Fish fish=new Fish();
            fish.Flee();
            fish.Hunt();
            
        }
    }
}
