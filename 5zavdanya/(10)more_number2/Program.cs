using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_number2
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2;
            Console.Write("Уведiть перше число: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Уведiть перше друге: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            string msg;

            msg = (num1 > num2) ? "Перше число бiльше за друге" : "Друге число бiльше за перше";

            Console.WriteLine(msg);
        }
    }
}
