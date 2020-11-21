using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.OCP
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport developerReports)
        {
            DeveloperReport = developerReports;
        }

        public abstract double CalculateSalary();
        ////{
        ////    double totalSalaries = 0D;

        ////    foreach (var devReport in _developerReports)
        ////    {
        ////        totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
        ////    }

        ////    return totalSalaries;
        ////}
    }
}
