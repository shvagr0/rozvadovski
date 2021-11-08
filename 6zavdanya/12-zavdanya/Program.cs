using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Уведiть двозначне число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num / 10 == 7 || num % 10 == 7)
            {
                Console.WriteLine($"Число {num} мiстить цифру 7");
            }
            else
            {
                Console.WriteLine($"Число {num} не мiстить цифру 7");
            }
        }
    }
}
