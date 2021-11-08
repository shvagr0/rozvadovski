using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zavadanya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть значення першого елемента арифметичної прогресiї: ");
            double x0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть значення другого елемента арифметичної прогресiї: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            double progres = x1 - x0;

            byte n = Convert.ToByte(Console.ReadLine());
            double sum = 0;
            double result = x0;

            for (int i = 0; i < n; i++)
            {
                sum += result;
                result += progres;
            }

            Console.WriteLine("Сума перших {0} елементiв арифметичної прогресiї = {1}", n, sum);
            Console.ReadKey();

        }
    }
}
