using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.Stretegy
{
    public class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public SeniorDevSalaryCalculator()
        {

        }
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports)
        {
            return developerReports
            .Where(r => r.Level == DeveloperLevel.Senior)
            .Select(r => (r.WorkingHours * r.HourlyRate * 1.2))
            .Sum();
        }
    }
}
