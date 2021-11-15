using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());

            y = Math.Sqrt(x - 10);

            if (x < 10)
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
