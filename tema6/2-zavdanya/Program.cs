using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Дiапазон чисел вiд 1 до ");
            int x = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int number = 0;
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    number++;
                }
            }
            Console.WriteLine("В дiапазонi чисел вiд 1 до {0} є {1} парних чисел", x, number);
            Console.WriteLine("В дiапазонi чисел вiд 1 до {0} сума всiх парних чисел дорiвнює {1}", x, sum);
        }
    }
}
