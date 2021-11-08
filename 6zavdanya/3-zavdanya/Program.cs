using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            byte month = Convert.ToByte(Console.ReadLine());        //ввід кількості місяців
            double cash = Convert.ToDouble(Console.ReadLine());     //ввід суми грошей які є в банку

            double money = cash;

            /* цикл який обчислює баланс після n кількості місяців */
            for (int i = 1; i <= month; i++)
            {
                cash *= 1.07;
            }

            Console.WriteLine("За {0} мiсяцiв баланс збiльшився на {1} грн", month, cash - money);
            Console.ReadKey();
        }
    }
}
