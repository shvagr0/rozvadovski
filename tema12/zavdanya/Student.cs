using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya
{
    class Person
    {
        protected string firstname;
        protected string lastname;
        protected byte age;

        public Person(string firstname, string lastname, byte age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public void PersonInfo()
        {
            Console.WriteLine("{0} {1} {2} років",lastname,firstname,age);
        }
    }

    class Student : Person
    {
        private string group;
        private Course[] courses;

        public Student(string firstname, string lastname, byte age, string group, Course[] courses) : base(firstname, lastname, age)
        {
            this.group = group;
            this.courses = courses;
        }

        public new void PersonInfo()
        {
            Console.WriteLine("{0} {1} {2} років (група-{3})", lastname, firstname, age, group);
            Console.WriteLine("Курси:");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.name + "(" + course.hours + " годин);");
            }
        }
    }
}
