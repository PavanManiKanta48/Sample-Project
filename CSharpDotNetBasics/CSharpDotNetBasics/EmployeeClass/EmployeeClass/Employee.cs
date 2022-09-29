using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    internal class Employee
    {
        private string  _FirstName;
        
        private string _LastName;

        public string FirstName
        {
            get { return _FirstName; }      //The get Accessor is used to read the _EmployeeId private variable value
            set { _FirstName = value; }     //The Set Accessor is used to set the _EmployeeId private variable value
        }
        public string SecondName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public void FullName()        {
            
            Console.WriteLine(FirstName+" "+SecondName);
        }
    }
}
