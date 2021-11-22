using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_8
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Запущено конструктор");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
        }
    }
}
