using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumpar = 0;
            int sumnep = 0;
            int number_nep = 0;
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    sumpar += i;
                }
                else
                {
                    sumnep += i;
                    number_nep++;
                }
            }
            Console.WriteLine(sumpar);
            Console.WriteLine(sumnep / number_nep);
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}^2 = {1}", i, i * i);
                }

            }
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                if (i != 33)
                {
                    Console.WriteLine("{0}^2 = {1}", i, i * i);
                }
            }
        }
    }
}
