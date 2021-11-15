using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            while (true)
            {

                Console.WriteLine("Уведіть два числа що знайти їхній добуток");
                Console.Write("Перше число = ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Друге число = ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Введено недопустимі числа");
                }
                else break;
            }
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);

        }
    }
}
