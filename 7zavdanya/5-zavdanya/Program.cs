using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[50];

            Random rand = new Random();

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rand.Next(0, 100);           //Присвоємо рандомних значень елементам масиву 
            }

            int num = Convert.ToInt32(Console.ReadLine());      //Ввід числа яке ми маємо перевірити на наявність в масиві

            bool check = false;

            for (int i = 0; i < M.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {M[i]}");    //Вивід значень масиву для перевірки правильної роботи програми
                if (M[i] == num)            //Перевірка на наявні введеного числа в масиві
                {
                    check = true;
                }
            }
            /*вивід повідомлення про наявність або відсутність введеного числа в масиві*/
            if (check)
            {
                Console.WriteLine($"Число {num} є в масивi");
            }
            else
            {
                Console.WriteLine($"Числа {num} немає в масивi");
            }
        }
    }
}
