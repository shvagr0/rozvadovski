using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_3
{
    class Arr
    {
        private int[] arr;

        public Arr(int[] arr)
        {
            this.arr = arr;
        }

        private int SumArr(int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += i;
            }
            return result;
        }

        private int DobutokArr(int[] arr)
        {
            int result = 1;
            foreach (int i in arr)
            {
                result *= i;
            }
            return result;
        }

        public void WriteResult()
        {
            Console.WriteLine("Сума всіх елементів масиву(+) / добуток всіх елементів масиву(*)");
            string i = Console.ReadLine();
            switch (i)
            {
                case "+":
                    Console.WriteLine(SumArr(arr));
                    break;
                case "*":
                    Console.WriteLine(DobutokArr(arr));
                    break;
                default:
                    Console.WriteLine("Ви ввели невірний символ");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[22];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }

            Arr ar = new Arr(arr);
            ar.WriteResult();
        }
    }
}
