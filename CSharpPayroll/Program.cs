using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            PayRollApp pr = new PayRollApp();
            pr.GeneratePayRoll();
            Console.ReadLine();
        }
    }
}
