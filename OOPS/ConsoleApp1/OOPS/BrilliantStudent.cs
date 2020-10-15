using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    public class BrilliantStudent : Student
    {
        public BrilliantStudent()
        {
            Console.WriteLine("Brilliant student");
        }

        public override int CalculateFees()
        {
            return 10 + 30;
        }
    }
}
