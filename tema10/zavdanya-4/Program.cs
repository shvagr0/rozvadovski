using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_4
{
    class Student
    {
        public string name;
        public byte course;
        public byte age;
        static public byte num = 0;

        public Student()
        {
            num++;
        }
        public Student(string name, byte course, byte age)
        {
            this.name = name;
            this.course = course;
            this.course = age;
            num++;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Vladislav", 2, 16);
            Student student2 = new Student();
            Student student3 = new Student();

            Console.WriteLine(Student.num);
        }
    }
}
