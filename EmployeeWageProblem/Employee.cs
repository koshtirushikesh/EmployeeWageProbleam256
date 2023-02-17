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
        const int FullTime = 1;
        const int PartTime = 2;

        string Company;
        int TotalWage = 0;
        int TotalWorkingHours = 0;
        int TotalWorkingDays = 0;
        int WorkingHour = 0;

        int MaxOfWorkingHours = 0;
        int MaxOfWorkingDays = 0;
        int WagePerHour = 0;
        public Employee(string Company, int MaxOfWorkingHours, int MaxOfWorkingDays, int WagePerHour)
        {
            this.Company = Company;
            this.MaxOfWorkingHours = MaxOfWorkingHours;
            this.MaxOfWorkingDays = MaxOfWorkingDays;
            this.WagePerHour = WagePerHour;
        }
        public int GetWorkingHours(int check)
        {
            int WorkingHour;
            switch (check)
            {
                case FullTime: WorkingHour = 8; break;
                case PartTime: WorkingHour = 4; break;
                default: WorkingHour = 0; break;
            }
            return WorkingHour;
        }

        public void CalculateWageTillCondition()
        {
            while (TotalWorkingDays < MaxOfWorkingDays && TotalWorkingHours < MaxOfWorkingHours)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int check = random.Next(3);

                WorkingHour = GetWorkingHours(check);
                TotalWorkingHours += WorkingHour;
                int DailyWage = WagePerHour * WorkingHour;
                Console.WriteLine(" Day :" + TotalWorkingDays + " Wage is: " + DailyWage);
                TotalWage += DailyWage;
            }
            Console.WriteLine(" \nEmploye Wage for Company: " + Company);
            Console.WriteLine("Total Employee Wage is : " + TotalWage + " Total Employee Hours : " + TotalWorkingHours + "\n");
        }

        public string ToString()
        { 
            return 
                "\n *********** Company  : " + Company +
                "\n Total Employee Wage  : " + TotalWage +
                "\n Total Employee Hours : " + TotalWorkingHours;
        }

    }
}
