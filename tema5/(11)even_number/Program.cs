using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Уведiть число: ");
            num = Convert.ToInt32(Console.ReadLine());

            string msg;

            msg = (num % 2 == 0) ? "парне" : "непарне";

            Console.WriteLine("Число {0} {1}", num, msg);
        }
    }
}
