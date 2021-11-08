using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 != 0)
            {
                Console.WriteLine("{0} на {1} нацiло недiлиться", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            }
        }
    }
}
