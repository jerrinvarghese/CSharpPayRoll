using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPayroll
{
    class PermanentEmployee:Employee
    {
         int _PFAccountNumber;
         int _NoOfLeaves;
         int _pay;
        public float P_salary;

        public PermanentEmployee(string name,int pay, int NoOfLeaves):base(name)
        {
            _pay = pay;
            _NoOfLeaves = NoOfLeaves;
        }
        public override double CalculateSalary()
        {
            
            P_salary = (_pay * (30 - _NoOfLeaves) )/ 30;
            return P_salary;
        }
    }
}
