using System;

namespace variant1_6_11
{
    class Program
    {
        static Student[] ReadStudentsArray(int n = 1)
        {
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть прізвище {i + 1} студента: ");
                students[i].surname = Console.ReadLine();

                Console.Write($"Введіть ім'я {i + 1} студента: ");
                students[i].name = Console.ReadLine();

                Console.Write($"Введіть шифр групи {i + 1} студента: ");
                students[i].group = Console.ReadLine();

                Console.Write($"Введіть курс {i + 1} студента: ");
                students[i].year = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Введіть кількість предметів {i + 1} студента: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Result[] results = new Result[num];

                for (int j = 0; j < num; j++)
                {
                    Console.Write($"Введіть назву {j + 1} предмета для {i + 1} студента: ");
                    results[j].subject = Console.ReadLine();

                    Console.Write($"Введіть П.І.Б викладача {j + 1} предмета для {i + 1} студента: ");
                    results[j].teacher = Console.ReadLine();

                    Console.Write($"Введіть кількість балів з {j + 1} предмета для {i + 1} студента: ");
                    results[j].points = Convert.ToInt32(Console.ReadLine());
                }

                students[i].results = results;
            }
            return students;
        }

        static void PrintStudent(Student st)
        {
            Console.WriteLine($"{st.surname} {st.name}\n Група {st.group}-{st.year}");
            for (int i = 0; i < st.results.Length; i++)
            {
                Console.WriteLine($"Предмет {st.results[i].subject} (Викладач {st.results[i].teacher})\n Кількість балів = {st.results[i].points}");
            }
        }

        static void PrintStudents(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                PrintStudent(students[i]);
            }
        }

        static void GetStudentsInfo(Student[] sts) //TODO!!
        {
            for (int i = 0; i < sts.Length; i++)
            {
                Console.WriteLine($"");
            }
        }

        static void SortStudentsByPoints(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].GetAveragePoints() > students[j].GetAveragePoints())
                    {
                        Student temp = students[j - 1];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Title = "Лабораторна робота №4";
            Console.SetWindowSize(100, 25);

            Console.Write("Введіть кількість студентів: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[num];
            students = ReadStudentsArray(students.Length);

            PrintStudents(students);

            SortStudentsByPoints(students);

            PrintStudents(students);

            Console.ReadKey();
        }
    }
}
