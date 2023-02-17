using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.CalculateWageTillCondition("Dmart", 150, 25, 10);
            employee.CalculateWageTillCondition("relience", 100, 20, 30);
          
            Console.WriteLine("All Employee Wage ");
            employee.Display();

            Console.ReadLine();
        }
    }
}
