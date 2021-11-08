using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                Console.WriteLine("Перше число менше за друге число");
            }
            else if (x > y)
            {
                Console.WriteLine("Друге число менше за перше число"); ;
            }
            else
            {
                Console.WriteLine("Числа рiвнi");
            }
        }
    }
}
