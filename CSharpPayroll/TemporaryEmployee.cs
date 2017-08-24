using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPayroll
{
    class TemporaryEmployee:Employee
    {
        int _WagePerHour;
        int _HoursWorked;
        string _ContractDate;
        int _OT;
        public float t_salary;

        public TemporaryEmployee(string name,int WagePerHour, int HoursWorked, int OT):base(name)
        {
            _WagePerHour = WagePerHour;
            _HoursWorked = HoursWorked;
            _OT = OT;

        }
        public override double CalculateSalary()
        {
            
            t_salary = (_HoursWorked + _OT * 2) * _WagePerHour;
            return t_salary;
        }
    }
}
