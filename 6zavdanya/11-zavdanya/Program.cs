using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            int awg = (num1 + num2 + num3) / 3;

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Всi три числа рiвнi");
            }
            Console.WriteLine("Середнє арифметичне трьох чисел " + awg);

        }
    }
}
