using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.ISP
{
    public class MultifunctionalCar : IMultiFunctional
    {
        public void Drive()
        {
            Console.Write("this car is in driving mode");
        }

        public void Fly()
        {
            Console.Write("this car is in flying mode");
        }
    }
}
