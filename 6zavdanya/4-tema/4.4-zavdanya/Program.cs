using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть трьохзначне число");
            int number = Convert.ToInt32(Console.ReadLine());
            int num1 = number / 100;
            int num2 = (number - num1 * 100) / 10;
            int num3 = number % 10;
            int result = num1 * num2 * num3;
            if (number < 100 || number >= 1000)
            {
                Console.WriteLine("Невiрно введене число");
            }
            else
            {
                Console.WriteLine("{0} * {1} * {2} = {3}", num1, num2, num3, result);
            }
        }
    }
}
