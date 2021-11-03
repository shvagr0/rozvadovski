using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electricity_cost_calculator
{
    class Program
    {
        private const float before100 = 0.9f, after100 = 1.68f;
        static void Main(string[] args)
        {

            float kw;
            Console.Write("Уведiть кiлькiсть витраченоi електроенергii(кВт): ");
            kw = (float)Convert.ToDouble(Console.ReadLine());

            float cost = (kw < 100) ? kw * before100 : (kw - 100) * after100 + 100 * before100;

            Console.WriteLine("За {0} кВт потрібно заплатити {1} грн", kw, cost);
            Console.ReadKey();
        }
    }
}
