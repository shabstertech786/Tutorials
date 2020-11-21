using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPatterns.Stretegy
{
    public enum DeveloperLevel
    {
        Senior,
        Junior
    }
    public class JuniorDevSalaryCalculator : ISalaryCalculator
    {
        public JuniorDevSalaryCalculator()
        {
        }
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> developerReports)
        {
            return developerReports
            .Where(r => r.Level == DeveloperLevel.Junior)
            .Select(r => (r.WorkingHours * r.HourlyRate))
            .Sum();
        }
    }
}
