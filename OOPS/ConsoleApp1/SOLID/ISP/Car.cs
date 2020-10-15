using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.ISP
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("this car can only be operated in driving mode");
        }

    }
}
