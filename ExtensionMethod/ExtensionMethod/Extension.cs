using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
     static class Extension
    {
        public static int GetDigits(this int Num) //i am creating an extension for predefined datatype integer
        {
            int Count = 0;
            while (Num != 0)
            {
                Count++;
                Num=Num/10;
            }
            return Count;
        }
    }
}
