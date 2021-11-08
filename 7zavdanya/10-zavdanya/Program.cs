using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 5];
            Random rand = new Random();

            /*Присвоєння рандомних значень масиву*/
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

            /*Вивід добутку стовбця у*/
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                int result = 1;
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    result *= arr[x, y];
                }
                Console.Write(result + "\t");
            }
            Console.WriteLine();

        }
    }
}
