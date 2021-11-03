using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть ваш вiк: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Ви не можете скористатись усiма можливостями програми");
            }
            else
            {
                Console.WriteLine("Вiтаємо ви можете скористатись усiма можливостями програми");
            }


            Console.ReadKey();

        }
    }
}
