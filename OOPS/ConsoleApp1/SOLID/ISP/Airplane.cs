using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.ISP
{
    public class Airplane : IPlane
    {
        public void Fly()
        {
            Console.WriteLine("the plane can only be operated in flying mode");
        }
    }
}
