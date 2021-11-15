using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_4
{
    class Student
    {
        public string surname;
        public string name;
        public int course;
        public int years;

        public Student(string surname, string name, int course, int years)
        {
            this.surname = surname;
            this.name = name;
            this.course = course;
            this.years = years;
        }


    }
    class Program
    {
        static int PrintStudents(Student[] students)
        {
            foreach (Student i in students)
            {
                Console.WriteLine($"{i.surname} {i.name} Курс-{i.course} Вік: {i.years} років");
            }
            return students.Length;
        }

        static void Main(string[] args)
        {
            Student student1 = new Student("Розвадоський", "Владислав", 2, 16);
            Student student2 = new Student("Зміяк", "Назар", 2, 16);
            Student student3 = new Student("Ткачук", "Денис", 3, 17);

            Student[] students = new Student[] { student1, student2, student3 };

            Console.WriteLine("Кількість студентів = {0}\n", PrintStudents(students));

        }
    }
}
