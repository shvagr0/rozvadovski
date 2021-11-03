using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());

            y = Math.Sqrt(5 - x) / (x - 1);

            if (x > 5 || x == 1)
            {
                Console.WriteLine("Обчислити неможливо!");
            }
            else
            {
                Console.WriteLine($"y = {y}");
            }
        }
    }
}
