using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    public class AverageStudent : Student
    {
        public AverageStudent()
        {
            StudentType = StudentTypes.Average;
            Console.WriteLine("constructing averagestudent");
        }
        public override int CalculateFees()
        {
            return 10 + 20;
        }
    }
}
