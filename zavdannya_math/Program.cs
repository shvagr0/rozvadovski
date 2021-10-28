using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zavdannya_math
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            //ввід 
            Console.WriteLine("Enter x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter z:");
            z = Convert.ToDouble(Console.ReadLine());

            //обчислення
            double result9 = Math.Abs(Math.Pow(x, x / y) - Math.Pow(y / x, 1f / 3)) + (y - x) * (Math.Cos(y) - z / (y - x)) / 1 + Math.Pow((y - x), 2);
            double result10 = Math.Pow(2, -x) * Math.Sqrt(x + Math.Pow(Math.Abs(y), 1f / 4) * Math.Pow(Math.Exp(x - 1 / Math.Sin(z)), 1f / 3));
            double result11 = Math.Pow(y, Math.Pow(Math.Abs(x), 1f / 3)) + Math.Pow(Math.Cos(y), 3) * (Math.Abs(x - y) * (1 + Math.Pow(Math.Sin(z), 2) / Math.Sqrt(x + y))) / (Math.Exp(Math.Abs(x - y)) + x / 2);
            double result12 = Math.Pow(2, Math.Pow(y, x)) + (Math.Pow(Math.Pow(3, x), y) * -1 * (y * (Math.Atan(z) - (1f / 3)) / (Math.Abs(x) + (1f / Math.Pow(y, 2) + 1))));
            double result13 = Math.Pow(y + Math.Pow(x - 1, 1f / 3), 1f / 4) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));
            double result14 = Math.Pow(y, (x + 1)) / (Math.Pow(Math.Abs(y - 2), 1f / 3) + 3) + (x + y / 2) / 2 * Math.Abs(x + y) * Math.Pow(x + 1, (-1 / Math.Sin(z)));

            //вивід
            Console.WriteLine("\nResult(9) = " + result9);
            Console.WriteLine("Result(10) = " + result10);
            Console.WriteLine("Result(11) = " + result11);
            Console.WriteLine("Result(12) = " + result12);
            Console.WriteLine("Result(13) = " + result13);
            Console.WriteLine("Result(14) = " + result14);
            Console.ReadKey();

        }
    }
}
