using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 8];

            Random rand = new Random();

            /*Запис рандомних значень в масив*/
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    arr[x, y] = rand.Next(0, 100);
                }
            }

            /*Вивід масиву у вигляді матриці*/
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    Console.Write(arr[x, y] + "\t");
                }
                Console.WriteLine("\n");
            }

            int num = 0;        //Змінна в яку буде записуватися кількість парних елементів масиву

            foreach (int k in arr)
            {
                if (k % 2 == 0)
                {
                    num++;
                }
            }

            Console.WriteLine("Кiлькiсть парних елементiв в масивi = " + num);
        }
    }
}
