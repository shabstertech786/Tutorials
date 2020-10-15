using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID.DIP
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Gender.ToString()} - {this.Position.ToString()}";
        }
    }
}
