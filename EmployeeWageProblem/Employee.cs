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
        public static int GetWorkingHours(int check)
        {
            const int FullTime = 1;
            const int PartTime = 2;
            int WorkingHour;

            switch(check)
            {
                case FullTime: WorkingHour = 8; break;
                case PartTime: WorkingHour = 4; break;

                default : WorkingHour = 0; break;
            }
            return WorkingHour;
        }

        public void CalculateDailyWage()
        {
            Random random = new Random();
            int check = random.Next(3);

            int WagePerHour = 20;
            int DailyWage = 0;

            int WorkingHour = GetWorkingHours(check);
            
            DailyWage = WagePerHour * WorkingHour;
            Console.WriteLine(" Daily Wage is : " + DailyWage);
        }



    }
}
