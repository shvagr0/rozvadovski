using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya
{
    partial class Student
    {
        public string name;
        public string surname;
        public int course;
        public int age;

        public Student()
        {

        }

        public Student(string name, string surname, int course, int age)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
            this.age = age;
        }

        public void Info()
        {
            Console.WriteLine($"{surname} {name} Курс: {course} Вік {age} років");
        }

    }
    class Program
    {
        static void Sort_age(Student[] arr)
        {
            Student temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].age > arr[j].age)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Sort_marks(Student[] arr)
        {
            Student temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].mark1 >= 10 && arr[j].mark2 >= 10 && arr[j].mark3 >= 10 && arr[j].mark4 >= 10)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            students[0] = new Student("Владислав", "Розвадовський", 2, 16);
            students[1] = new Student("Bill", "Gates", 5, 24);
            students[2] = new Student("Will", "Miller", 3, 22);
            students[3] = new Student("Tamara", "Stone", 2, 17);
            students[4] = new Student("Victor", "Mask", 1, 15);

            students[5].name = "Denis";
            students[5].surname = "Vilson";
            students[5].course = 3;
            students[5].age = 17;

            students[6].name = "Ivan";
            students[6].surname = "Mihaluk";
            students[6].course = 3;
            students[6].age = 17;

            students[7].name = "Max";
            students[7].surname = "Smit";
            students[7].course = 2;
            students[7].age = 15;

            students[8].name = "Dima";
            students[8].surname = "Fedchak";
            students[8].course = 4;
            students[8].age = 20;

            students[8].name = "Nazar";
            students[8].surname = "Zmiyak";
            students[8].course = 3;
            students[8].age = 21;

            foreach (Student s in students)
            {
                if (s.age > 20)
                {
                    s.Info();
                }
            }

            Sort_age(students);

            foreach (Student s in students)
            {
                s.EnterMark();
            }

            foreach (Student s in students)
            {
                if (s.mark1 == 2 || s.mark2 == 2 || s.mark3 == 2 || s.mark4 == 2)
                {
                    s.Info();
                }
            }

            Sort_marks(students);

            Student student = students[students.Length - 1];
        }
    }
}
