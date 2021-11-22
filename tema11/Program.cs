using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema11
{
    class Student
    {
        private string name;
        public string Name { get; set; }

        private string surname;
        public string Surname { get; set; }

        private byte course;
        private byte age;

        public int stipend { get; set; }

        private byte rating1;
        public byte Rating1
        {
            set
            {
                if (value >= 2 && value <= 5)
                {
                    rating1 = value;
                }
                else
                {
                    Console.WriteLine("Недопустима оцінка");
                }
            }
            get { return rating1; }
        }

        private byte rating2;
        public byte Rating2
        {
            set
            {
                if (value >= 2 && value <= 5)
                {
                    rating2 = value;
                }
                else
                {
                    Console.WriteLine("Недопустима оцінка");
                }
            }
            get { return rating2; }
        }

        private byte rating3;
        public byte Rating3
        {
            set
            {
                if (value >= 2 && value <= 5)
                {
                    rating3 = value;
                }
                else
                {
                    Console.WriteLine("Недопустима оцінка");
                }
            }
            get { return rating3; }
        }

        private byte rating4;
        public byte Rating4
        {
            set
            {
                if (value >= 2 && value <= 5)
                {
                    rating4 = value;
                }
                else
                {
                    Console.WriteLine("Недопустима оцінка");
                }
            }
            get { return rating4; }
        }

        private byte rating5;
        public byte Rating5
        {
            set
            {
                if (value >= 2 && value <= 5)
                {
                    rating5 = value;
                }
                else
                {
                    Console.WriteLine("Недопустима оцінка");
                }
            }
            get { return rating5; }
        }

        public Student(string name, string surname, byte course, byte age)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine(surname + " " + name + " Курс-" + course + " Вік=" + age);
        }

        static public void PrintOldStudents(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].age > 20)
                {
                    Console.WriteLine(students[i].surname + " " + students[i].name + " Курс-" + students[i].course + " Вік=" + students[i].age);
                }
            }
        }

        static public void SortStudents(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                Student temp;
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].age > students[j].age)
                    {
                        temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }
        public void Сhange()
        {
            Console.WriteLine("Введіть курс студента {0} {1}", surname, name);
            course = Convert.ToByte(Console.ReadLine());
        }

        static public void Сhange(Student student)
        {
            Console.WriteLine("Введіть курс студента {0} {1}", student.surname, student.name);
            student.course = Convert.ToByte(Console.ReadLine());
        }

        public void SetRating()
        {
            Console.WriteLine("Введіть оцінки {0} {1}", surname, name);
            Rating1 = Convert.ToByte(Console.ReadLine());
            Rating2 = Convert.ToByte(Console.ReadLine());
            Rating3 = Convert.ToByte(Console.ReadLine());
            Rating4 = Convert.ToByte(Console.ReadLine());
        }

        static public void PrintWorstStudents(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Rating1 == 2 || students[i].Rating2 == 2 || students[i].Rating3 == 2 || students[i].Rating4 == 2)
                {
                    Console.WriteLine(students[i].surname + " " + students[i].name + " Курс-" + students[i].course + " Вік=" + students[i].age);
                }
            }
        }

        static public void SerStipend(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Введіть стипендію {0} {1}", students[i].Surname, students[i].Name);
                students[i].stipend = Convert.ToInt32(Console.ReadLine());
            }
        }

        static public void BestStipend(Student[] students)
        {
            Student best = students[0];
            for (int i = 0; i < students.Length; i++)
            {
                if (best.stipend < students[i].stipend)
                {
                    best = students[i];
                }
            }
            Console.WriteLine("Найвища стипендія у {} {} ({}uan)", best.Surname, best.Name, best.stipend);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10]
            {
                new Student("Макс","Прізвище",4,21),
                new Student("Влад","Прізвище",5,23),
                new Student("Вова","Прізвище",1,15),
                new Student("Стас","Прізвище",2,16),
                new Student("Дмитро","Прізвище",2,18),
                new Student("Олег","Прізвище",3,21),
                new Student("Денис","Прізвище",3,20),
                new Student("Давид","Прізвище",1,16),
                new Student("Артур","Прізвище",2,18),
                new Student("Олег","Прізвище",5,22)
            };

            Student.PrintOldStudents(students);

            students[2].Сhange();
            Student.Сhange(students[4]);
            students[3].Сhange();

            Student.SortStudents(students);

            for (int i = 0; i < students.Length; i++)
            {
                students[i].SetRating();
            }

            Console.WriteLine("Студенти у яких є мінімум одна негативна оцінка");
            Student.PrintWorstStudents(students);

            Student.SerStipend(students);

            Student.BestStipend(students);

        }
    }
}
