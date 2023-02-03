using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Employee
    {
        public int GetWorkingHours()
        {
            const int FullTime = 1;
            const int PartTime = 2;
            int WorkingHour;

            Random random= new Random();
            int check =random.Next(3);

            switch(check)
            {
                case FullTime: WorkingHour = 8; break;
                case PartTime: WorkingHour = 4; break;

                default : WorkingHour = 0; break;
            }
            return WorkingHour;
        }

        public int CalculateDailyWage()
        {
            int WorkingHour = GetWorkingHours();
            int WagePerHour = 20;
            int DailyWage = 0;
            DailyWage = WagePerHour * WorkingHour;
            Console.WriteLine(" Wage is : " + DailyWage);
            return DailyWage;
        }


    }
}
