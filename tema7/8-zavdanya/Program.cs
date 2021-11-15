using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[7, 5];
            Random rand = new Random();

            /*Запис рандомних значень в масив*/
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    arr[x, y] = rand.Next(0, 100);
                }
            }

            /*Вивід значень масиву у вигляді матриці*/
            for (int x = 0; x < arr.GetLength(0); x++)      //Рядок 
            {
                int max = arr[x, 0];        //Змінна яка буде зберігати максимальне значення рядка х
                for (int y = 0; y < arr.GetLength(1); y++)  //Стовбець 
                {
                    if (max < arr[x, y])
                    {
                        max = arr[x, y];
                    }
                    Console.Write(arr[x, y] + "\t");
                }
                /*Після виводу рядку виводиться максимальне значення у цьому рядку*/
                Console.Write("Макс. значення в рядку = " + max);
                Console.WriteLine("\n");
            }
        }
    }
}
