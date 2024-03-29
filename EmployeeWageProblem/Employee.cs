﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Employee : IEmpWageBuilder
    {
        public const int FullTime = 1;
        public const int PartTime = 2;

        public int WorkingHour = 0;
        public int MaxOfWorkingHours = 0;
        public int MaxOfWorkingDays = 0;
        public int WagePerHours = 0;

        List<EmployeModel> employesWageList = new List<EmployeModel>();

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

        public void CalculateWageTillCondition(string Company, int MaxOfWorkingHours, int MaxOfWorkingDays, int WagePerHour)
        {
            EmployeModel employe = new EmployeModel();
            employe.Company = Company;
            while (employe.TotalWorkingDays < MaxOfWorkingDays && employe.TotalWorkingHours < MaxOfWorkingHours)
            {
                employe.TotalWorkingDays++;
                Random random = new Random();
                int check = random.Next(3);

                WorkingHour = GetWorkingHours(check);
                employe.TotalWorkingHours += WorkingHour;
                int DailyWage = WagePerHour * WorkingHour;
                Console.WriteLine(" Day :" + employe.TotalWorkingDays + " Wage is: " + DailyWage);
                employe.TotalWage += DailyWage;
            }
            Console.WriteLine(" \nEmploye Wage for Company: " + employe.Company);
            Console.WriteLine("Total Employee Wage is : " + employe.TotalWage + " Total Employee Hours : " + employe.TotalWorkingHours + "\n");
            SaveFunction(employe);
        }

        public void SaveFunction(EmployeModel employe)
        {
            employesWageList.Add(employe);
        }

        public void Display(string name)
        {
            foreach (var i in employesWageList)
            {
                if (i.Company.Equals(name))
                {
                    Console.WriteLine(
                        "\n *********** Company  : " + i.Company +
                        "\n Total Employee Wage  : " + i.TotalWage +
                        "\n Total Employee Hours : " + i.TotalWorkingHours +
                        "\n Total Employee Days  : " + i.TotalWorkingDays);
                }
            }
        }
    }
}
