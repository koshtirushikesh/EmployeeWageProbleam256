using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class CompanyEmpWageModel
    {
        public string Company { get; set; }
        public int TotalWage { get; set; }
        public int TotalWorkingHours { get; set; }
        public int TotalWorkingDays { get; set; }

        public int WagePerHour { get; set; }
        public int MaxOfWorkingDays { get; set; }
        public int MaxOfWorkingHours { get; set; }

        public CompanyEmpWageModel(string Company, int MaxOfWorkingHours, int MaxOfWorkingDays, int WagePerHour)
        {
            this.Company = Company;
            this.MaxOfWorkingHours = MaxOfWorkingHours;
            this.MaxOfWorkingDays = MaxOfWorkingDays;
            this.WagePerHour = WagePerHour;
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
