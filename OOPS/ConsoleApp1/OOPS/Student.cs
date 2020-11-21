using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("base abstract class");
        }
        public enum StudentTypes{
            Normal,
            Average,
            Brilliant,
        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }

        public StudentTypes StudentType{ get; set; }
        public virtual int CalculateFees()
        {
            Console.WriteLine("base calculate fees");
            return this.CalculateFees();
        }
        public override string ToString()
        {
            return $"{this.FirstName + " " + this.LastName}";
        }

    }
}
