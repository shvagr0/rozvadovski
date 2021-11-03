using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_of_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Уведiть довжину першоi сторони трикутника: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Уведiть довжину другоi сторони трикутника: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Уведiть довжину третьоi сторони трикутника: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if ((a + b) < c || (b + c) < a || (c + a) < b)
            {
                Console.WriteLine("Трикутник неможливий");
            }
            else
            {
                if (a == b && a == c && c == b)
                {
                    Console.WriteLine("Трикутник рiвносторонiй");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine("Трикутник рiвнобедрений");
                }
                else
                {
                    Console.WriteLine("Трикутник рiзносторонiй");
                }
            }

        }
    }
}
