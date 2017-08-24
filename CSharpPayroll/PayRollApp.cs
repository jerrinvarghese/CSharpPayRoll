using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPayroll
{
    class PayRollApp
    {
        public void GeneratePayRoll()
        {
            EmployeeRepository er = new EmployeeRepository();

            List<Employee> el = er.GetEmployees();
            foreach (Employee em in el)
            {
                Console.WriteLine("The name is " + em._EmpName);
                Console.WriteLine("The salary is " + em.CalculateSalary());
            }

        }
    }
}
