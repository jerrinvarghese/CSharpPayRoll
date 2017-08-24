using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPayroll
{
   abstract class Employee
    {
        public string _EmpName;
        public Employee (string ename)
        {
            _EmpName = ename;
        }
        public abstract double CalculateSalary();
    }
}
