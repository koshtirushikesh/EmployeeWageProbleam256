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

        public void CalculateWageTillCondition()
        {
            int TotalWage = 0;
            int TotalWorkingHours = 0;
            int TotalWorkingDays = 0;
            int MaxOfWorkingDays = 20;
            int MaxOfWorkingHours = 100;
            int WagePerHour = 20;
            int WorkingHour = 0;

            while (TotalWorkingDays < MaxOfWorkingDays && TotalWorkingHours < MaxOfWorkingHours)
            {
                TotalWorkingDays++;
                Random random= new Random();
                int check =random.Next(3);

                WorkingHour = GetWorkingHours(check);
                TotalWorkingHours += WorkingHour;
                int DailyWage = WagePerHour * WorkingHour;
                Console.WriteLine(" Day :" + TotalWorkingDays + " Wage is: " + DailyWage);
                TotalWage += DailyWage;
            }
            Console.WriteLine("Total Employee Wage is : " + TotalWage+" Total Employee Hours : "+TotalWorkingHours);
        }

    }
}
