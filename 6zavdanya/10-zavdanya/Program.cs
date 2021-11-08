using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Уведiть двозначне число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = (num / 10) + (num % 10);
            Console.Write("Уведiть число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < sum)
            {
                Console.WriteLine("Число А менше за суму цифр двозначного числа " + num);
            }
            else
            {
                Console.WriteLine("Число А бiльше за суму цифр двозначного числа " + num);
            }
        }
    }
}
