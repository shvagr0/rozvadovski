using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya
{
    enum Marks { відмінно = 12, добре = 9, задовільно = 6, незадовільно = 3 }
    struct Student
    {
        public string surname;
        public string name;
        public int course;
        public int age;

        public int mark1, mark2, mark3, mark4;

        public void EnterMark(Marks m1, Marks m2, Marks m3, Marks m4)
        {
            mark1 = (int)m1;
            mark2 = (int)m2;
            mark3 = (int)m3;
            mark4 = (int)m4;
        }
        public void EnterMark()
        {
            Console.WriteLine($"Введiть оцiнки студента: {surname} {name} ({course}-курс)");
            Console.Write("Mark 1 = ");
            mark1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 2 = ");
            mark2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 3 = ");
            mark3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 4 = ");
            mark4 = Convert.ToInt32(Console.ReadLine());
        }

        /*Метод для виводу інформації про студента*/
        public void Info()
        {
            Console.WriteLine($"{surname} {name}: Курс-{course}; Вiк {age} рокiв");
        }

        public void ShowMarks()
        {
            Console.WriteLine(mark1);
            Console.WriteLine(mark2);
            Console.WriteLine(mark3);
            Console.WriteLine(mark4);
        }
    }

    class Program
    {
        /*Функція яка сортує масив структур Student по значенню age*/
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
            Student[] arr = new Student[10];

            arr[0].surname = "Розвадовський";
            arr[0].name = "Владислав";
            arr[0].course = 2;
            arr[0].age = 16;

            arr[1].surname = "Маковiйчук";
            arr[1].name = "Василь";
            arr[1].course = 4;
            arr[1].age = 23;

            arr[2].surname = "Шевченко";
            arr[2].name = "Петро";
            arr[2].course = 3;
            arr[2].age = 21;

            arr[3].surname = "Шарiй";
            arr[3].name = "Назар";
            arr[3].course = 4;
            arr[3].age = 22;

            arr[4].surname = "Малярчук";
            arr[4].name = "Дмитро";
            arr[4].course = 2;
            arr[4].age = 18;

            arr[5].surname = "Ляшко";
            arr[5].name = "Олександр";
            arr[5].course = 1;
            arr[5].age = 15;

            arr[6].surname = "Лящовський";
            arr[6].name = "Максим";
            arr[6].course = 2;
            arr[6].age = 16;

            arr[7].surname = "Бiлейчук";
            arr[7].name = "Андрiй";
            arr[7].course = 2;
            arr[7].age = 17;

            arr[8].surname = "Моставчук";
            arr[8].name = "Петро";
            arr[8].course = 4;
            arr[8].age = 22;

            arr[9].surname = "Вакалюк";
            arr[9].name = "Денис";
            arr[9].course = 2;
            arr[9].age = 15;

            Console.WriteLine("Студенти старше 20 рокiв:");
            foreach (Student i in arr)
            {
                if (i.age > 20)
                {
                    Console.WriteLine(i.surname + " " + i.name);
                }
            }

            Console.WriteLine();

            /*Cортування студентів за віком*/
            Sort_age(arr);

            /*Ввід оцінок студентів*/
            foreach (Student i in arr)
            {
                i.EnterMark();
            }

            /*Студенти якi отримали хотяб одну двiйку*/
            Console.WriteLine("Студенти якi отримали хотяб одну двiйку:");
            foreach (Student i in arr)
            {
                if (i.mark1 == 2 || i.mark2 == 2 || i.mark3 == 2 || i.mark4 == 2)
                {
                    Console.WriteLine($"{i.surname} {i.name}");
                }
            }

            /*хто має всі оцінки «відмінно» перемістити в початок масиву*/
            Sort_marks(arr);

            /*Ввід оцінки студента перелічувальними даними*/
            arr[5].EnterMark(Marks.добре, Marks.добре, Marks.добре, Marks.добре);

            /*Вивід інформації про всіх студентів*/
            foreach (Student i in arr)
            {
                i.Info();
            }

            /*Вивід на екран відомостей про студентів, хто має лише оцінки «добре» або «відмінно»*/
            foreach (Student i in arr)
            {
                if (i.mark1 >= (int)Marks.добре && i.mark2 >= (int)Marks.добре && i.mark3 >= (int)Marks.добре && i.mark4 >= (int)Marks.добре)
                    i.Info();
            }
        }
    }
}
