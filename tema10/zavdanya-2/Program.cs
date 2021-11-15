using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_2
{
    class Program
    {
        static int MaxVal(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[30];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }

            Console.WriteLine(MaxVal(arr));
        }
    }
}
