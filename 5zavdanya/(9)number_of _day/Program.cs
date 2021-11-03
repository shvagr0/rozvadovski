using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of__day
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;

            Console.Write("Уведiть номер дня тиждня: ");
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедiлок");
                    break;
                case 2:
                    Console.WriteLine("Вiвторок");
                    break;
                case 3:
                    Console.WriteLine("Середа");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятниця");
                    break;
                case 6:
                    Console.WriteLine("Субота");
                    break;
                case 7:
                    Console.WriteLine("Недiля");
                    break;
                default:
                    Console.WriteLine("Помилка");
                    break;
            }
        }
    }
}
