using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya
{
    class Teacher : Person
    {
        public string faculty { get; set; }
        public Course[] courses;

        public Teacher(string firstname, string lastname, byte age, string faculty, Course[] courses) : base(firstname,lastname,age)
        {
            this.courses = courses;
            this.faculty = faculty;
        }

        public new void PersonInfo()
        {
            Console.WriteLine("{0} {1} {2} років (факультет - {3})", lastname, firstname, age, faculty);
            Console.WriteLine("Курси:");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.name + "(" + course.hours + " годин);");
            }
        }
    }
}
