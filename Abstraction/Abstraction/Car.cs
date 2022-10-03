using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class car //Abstract Class
    {
        public abstract void carSound();
        public void color()
        {
            Console.WriteLine("Car color was : Red");
        }
    }
    class Benz : car  //Implemtation Of Abstraction Class
    {
        public override void carSound()
        {
            Console.WriteLine("Car Sound : Tut Tut ..");
        }
    }
}
