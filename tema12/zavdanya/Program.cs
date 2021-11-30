using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya
{


    class Program
    {
        static void Main(string[] args)
        {
            RegularCourse[] courses =
            {
                new RegularCourse("C#", 200, 4),
                new RegularCourse("C++", 300, 12),
                new RegularCourse("Photoshop", 100, 3)
            };
         
            Student student = new Student("Vladislav", "Rozvadovski", 16, "programist", courses);
            student.PersonInfo();

            Teacher teacher = new Teacher("Bill", "Gates", 43,  "math", courses);
            teacher.PersonInfo();
        }
    }
}
