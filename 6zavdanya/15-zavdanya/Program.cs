using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] student = new int[28];        //масив з оцінками учнів
            for (int i = 0; i < student.Length; i++)
            {
                Console.Write("Оцiнка учня {0} = ", i + 1);
                student[i] = Convert.ToInt32(Console.ReadLine());       //ввід оцінки учня і
            }
            int two = 0;
            for (int j = 0; j < student.Length; j++)
            {
                if (student[j] == 2)        //якщо оцінка учня j дорівнює 2
                {
                    two++;                  //то значення two збільшується на 1
                }
            }
            Console.WriteLine(two);         //вивід кількось двійок із списку учнів
        }
    }
}
