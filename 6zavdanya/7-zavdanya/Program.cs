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
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x < y)
            {
                Console.WriteLine("Перше число менше\nДруге число бiльше");
            }
            else
            {
                Console.WriteLine("Друге число менше\nПерше число бiльше"); ;
            }
        }
    }
}
