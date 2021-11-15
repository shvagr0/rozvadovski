using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of__month
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;

            Console.Write("Уведiть номер мiсяця: ");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("Сiчень");
                    break;
                case 2:
                    Console.WriteLine("Грудень");
                    break;
                case 3:
                    Console.WriteLine("Березень");
                    break;
                case 4:
                    Console.WriteLine("Квiтень");
                    break;
                case 5:
                    Console.WriteLine("Травень");
                    break;
                case 6:
                    Console.WriteLine("Червень");
                    break;
                case 7:
                    Console.WriteLine("Липень");
                    break;
                case 8:
                    Console.WriteLine("Серпень");
                    break;
                case 9:
                    Console.WriteLine("Вересень");
                    break;
                case 10:
                    Console.WriteLine("Жовтень");
                    break;
                case 11:
                    Console.WriteLine("Листопад");
                    break;
                case 12:
                    Console.WriteLine("Грудень");
                    break;
                default:
                    Console.WriteLine("Помилка");
                    break;
            }
        }
    }
}
