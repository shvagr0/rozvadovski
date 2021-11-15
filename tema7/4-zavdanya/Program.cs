using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[30];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.NextDouble() * rand.Next(0, 100);
            }

            double max = arr[0];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    index = i;
                }

            }
            Console.WriteLine("Макс. значення = {0} iз iндексом масиву {1}", max, index);
        }
    }
}
