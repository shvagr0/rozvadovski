using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);      //Присмоїм рандомні значення елементам масиву(від -100 до 100)
            }

            int sum = 0;

            foreach (int j in arr)
            {
                if (j > 0)
                    sum += j;                       //Обчислюється сума всіх елементів масиву які більші нуля
            }

            Console.WriteLine(sum);                 //Вивід суми всіх елементів масиву які більші нуля
        }
    }
}
