using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];

            Random rand = new Random();

            for (int x = 0; x < arr.GetLength(0); x++)          //Рядки(індех)
            {
                for (int y = 0; y < arr.GetLength(1); y++)      //Стовбці(індех) 
                {
                    arr[x, y] = rand.Next(10, 100);             //Присвоєння рандомних значень елементам масиву
                }
            }

            int checky = arr.GetLength(1) - 1;                  //індех елемента масиву (в рядку!) який повиний дорівнювати нулю

            for (int x = 0; x < arr.GetLength(0); x++)          //Рядки(індех)
            {
                for (int y = 0; y < arr.GetLength(1); y++)      //Стовбці(індех)
                {
                    if (y == checky)
                    {
                        arr[x, y] = 0;                          //Занулення елементу масива 
                    }
                    Console.Write(arr[x, y] + "\t");            //Вивід рядка(х)
                }
                Console.WriteLine("\n");
                checky--;
            }


        }
    }
}
