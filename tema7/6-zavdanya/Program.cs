using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Random rand = new Random();

            /*Присвоєння рандомних значень масиву*/
            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rand.Next(0, 100);
            }

            /*Вивід масиву*/
            foreach (int k in arr)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            /*Ввід числа яке шукаєм в масиві*/
            int num = Convert.ToInt32(Console.ReadLine());

            /*Пошук індексів елементів масиву які дорівнюють введеному числу*/
            bool check = false;
            for (int x = 0; x < arr.Length; x++)
            {
                if (num == arr[x])
                {
                    check = true;
                    Console.Write(x + "; "); //Вивід індексів
                }
            }

            if (!check)     //Якщо числа яке ми ввели немає то виводим що цього числа в масиві немає
            {
                Console.WriteLine($"Числа {num} немає в масивi");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
