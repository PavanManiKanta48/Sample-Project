using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee EmpObj = new Employee();
            EmpObj.FirstName = "pavan";
            EmpObj.SecondName = "manikanta";
            EmpObj.FullName();
        }
    }
}
