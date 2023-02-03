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
            int present = 1;
            int WorkingHour;

            Random random = new Random();
            int check = random.Next(2);

            if (check == present)
            {
                Console.WriteLine("Employee is Present");
                WorkingHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
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
