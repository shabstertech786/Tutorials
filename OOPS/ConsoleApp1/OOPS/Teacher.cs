using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    public class Teacher
    {
        private Student student;
        public Teacher(Student student)
        {
            this.student = student;
        }

        public void WriteTeacher()
        {
            Console.WriteLine($"Teacher: {student.FirstName}");
        }
    }
}
