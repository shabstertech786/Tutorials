using ConsoleApp1.DesignPatterns.Stretegy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.OCP
{
    public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
