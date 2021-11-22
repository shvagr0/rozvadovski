using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_7
{
    class Program
    {
        static int MaxVal(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length - 1];
        }
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }

            Console.WriteLine(MaxVal(arr));

        }
    }
}
