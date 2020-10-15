using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.Stretegy
{
    public class SalaryCalculator
    {
        private readonly ISalaryCalculator salaryCalculator;
        public SalaryCalculator(ISalaryCalculator salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }
        public double CalculateTotalSalaries(IEnumerable<DeveloperReport> developerReports)
        {
            return salaryCalculator.CalculateTotalSalary(developerReports);
        }
    }
}
