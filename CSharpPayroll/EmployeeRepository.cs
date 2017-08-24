using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPayroll
{
    class EmployeeRepository
    {
        

        List<Employee> emplist = new List<Employee>();


         public List<Employee> GetEmployees()
        {
            emplist.Add(new TemporaryEmployee("ab",100, 10, 10));
            emplist.Add(new TemporaryEmployee("ac", 100, 11, 10));
            emplist.Add(new TemporaryEmployee("ad", 100, 12, 10));
            emplist.Add(new TemporaryEmployee("ae", 100, 13, 10));
            emplist.Add(new PermanentEmployee("ba",10000, 3));
            emplist.Add(new PermanentEmployee("bb", 10000, 2));
            emplist.Add(new PermanentEmployee("bc", 10000, 1));
            return emplist;
        }
    }
}
