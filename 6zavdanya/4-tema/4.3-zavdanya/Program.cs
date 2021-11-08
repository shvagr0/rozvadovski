using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 35; i < 87; i++)
            {
                if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
