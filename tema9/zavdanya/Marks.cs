using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya
{
    partial class Student
    {
        public int mark1, mark2, mark3, mark4;

        public void EnterMark()
        {
            Console.WriteLine($"Введiть оцiнки студента: {surname} {name} ({course}-курс)");
            Console.Write("Mark 1 = ");
            mark1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 2 = ");
            mark2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 3 = ");
            mark3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark 4 = ");
            mark4 = Convert.ToInt32(Console.ReadLine());
        }

    }
}
