using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.DIP
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeManager _empManager;
        public EmployeeStatistics(IEmployeeManager empManager)
        {
            _empManager = empManager;
        }
        public int CountFemaleManagers() =>
          _empManager.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
