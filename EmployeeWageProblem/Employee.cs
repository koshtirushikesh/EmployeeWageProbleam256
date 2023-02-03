using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Employee
    {
        public static int Attendance()
        {
            int FullTime = 1;
            int PartTime = 2;
            int WorkingHour;

            Random random = new Random();
            int check = random.Next(3);

            if (check == FullTime)
            {
                Console.Write("Employee is Present for full Time");
                WorkingHour = 8;
            }
            else if(check==PartTime)
            {
                Console.Write("Employee is Present for Part Time");
                WorkingHour = 4;
            }
            else
            {
                Console.Write("Employee is Absent");
                WorkingHour = 0;
            }

            return WorkingHour;
        }

        public void CalculateDailyWage()
        {
            int WorkingHour = Attendance();
            int WagePerHour = 20;
            int DailyWage = 0;
            DailyWage = WagePerHour * WorkingHour;
            Console.Write(" & Wage is : " + DailyWage);
        }


    }
}
