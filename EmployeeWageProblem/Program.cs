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
            Employee dmart = new Employee("Dmart", 150, 25, 10);
            Employee relince= new Employee("relience", 100, 20, 30);
            dmart.CalculateWageTillCondition();
            relince.CalculateWageTillCondition();
            Console.WriteLine(dmart.ToString());
            Console.WriteLine(relince.ToString());
            Console.ReadLine();
        }
    }
}
