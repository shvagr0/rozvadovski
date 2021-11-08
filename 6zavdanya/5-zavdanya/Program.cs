using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
