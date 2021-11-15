using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] B = new int[20];

            Random rand = new Random();

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rand.Next(0, 100);       //Задаєм рандомного значення елементам масиву
            }

            int sum = 0;

            for (int i = 0; i < B.Length; i++)
            {
                if (i % 2 != 0) continue;       //Якщо остача при ділені елементу масуву на 2 не дорівнює 0 то цикл пропускає хід
                sum += B[i];                    //Обчислюємо суму парних елементів масиву
                Console.Write($"{B[i]} + ");
            }

            Console.WriteLine($"= {sum}");      //Виводим суму всіх парних елементів масиву
        }
    }
}
