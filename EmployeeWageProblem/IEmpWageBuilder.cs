using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal interface IEmpWageBuilder
    {
        int GetWorkingHours(int check);
        void CalculateWageTillCondition(string Company, int MaxOfWorkingHours, int MaxOfWorkingDays, int WagePerHour);
        void SaveFunction(EmployeModel employee);
        void Display(string name);
    }
}
