using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIB_out
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Владислав";
            const string surname = "Розвадовський";
            const string middle_name = "Мирославович";

            int x = Console.Read();

            if (x == '0')
            {
                Console.WriteLine("{1} {0} {2}", name, surname, middle_name);
            }
            Console.ReadKey();
        }
    }
}
