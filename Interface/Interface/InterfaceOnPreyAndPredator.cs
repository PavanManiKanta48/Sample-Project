using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class InterfaceOnPreyAndPredator
    {
        
    }
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
     class Rabbit : IPrey
    {
        public  void Flee()
        {
            Console.WriteLine("Rabbit Run Away :");
        }
    }
    class Hawk : IPredator
    {

        public void Hunt()
        {
            Console.WriteLine("The Hauk Is Searching for food : ");
        }
    }
    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("Fish Run To Live :");
        }
        public void Hunt()
        {
            Console.WriteLine("Fish is Searching For hunt:");
        }
    }

}

