using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[100];             //Масив на 100 елементів

            int sum = 0;

            Random rand = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(0, 100);       //Заповнюємо масив рандомними числами (від 0 до 100)
            }

            foreach (int b in A)
            {
                Console.Write($"{b} + ");       //Виводим значення кожного елемента масиву
                sum += b;                       //Обчислення суми всіх елементів масиву
            }

            Console.WriteLine($"= {sum}");      //Виводим суму всіх значень масиву
        }
    }
}
