using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_zavdanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine()); //ввід числа
            int sum = 0;
            int x = 0;
            while (num != 0)
            {
                sum += num % 10;    //сума збільшується на значення останьої цифри числа
                num /= 10;          //відсікається остання цифра
                x++;                //х використовується для визначення кількость цифр в числі
            }
            Console.WriteLine(sum);      //вивід суми всіх цифр числа
            Console.WriteLine(sum / x);  //вивід сер. арифметчного суми всії цифр числа
        }
    }
}
