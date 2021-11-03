using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_number
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Уведiть перше число: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Увeдiть друге число: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            if (num1 == num2)
            {
                Console.WriteLine("Числа рiвнi");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Друге число бiльше за перше");
            }
            else
            {
                Console.WriteLine("Перше число бiльше за друге");
            }
        }
    }
}
