using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int awg;
            int num = 0;
            int x;

            while (true)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                else
                {
                    num++;
                    sum += x;
                }
            }
            awg = sum / num;
            Console.WriteLine("Кількiсть введених чисел: " + num);
            Console.WriteLine("Сума усiх введех чисел:" + sum);
            Console.WriteLine("Середнє арифметичне: " + awg);
        }
    }
}
