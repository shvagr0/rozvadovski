using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya_1
{
    class Matem
    {
        private int[] A;

        public Matem(int[] A)
        {
            this.A = A;
        }

        public void PrintArr()
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, A[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[25];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            Matem matem = new Matem(arr);

            matem.PrintArr();
        }
    }
}
