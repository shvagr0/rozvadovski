using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            Console.Write("Уведiть температуру води: ");
            temp = Convert.ToDouble(Console.ReadLine());

            if (temp <= 0)
            {
                Console.WriteLine($"Агрегатний стан води з температурою {temp}: \"Твердий\" ");
            }
            else if (temp >= 100)
            {
                Console.WriteLine($"Агрегатний стан води з температурою {temp}: \"Газоподiпний\" ");
            }
            else
            {
                Console.WriteLine($"Агрегатний стан води з температурою {temp}: \"Рiдкий\" ");
            }

        }
    }
}
