using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdanya
{
    abstract class Course
    {
        public string name;
        public int hours;

        public Course(string name, int hours)
        {
            this.name = name;
            this.hours = hours;
        }

        public abstract void CourseInfo();

    }

    class RegularCourse : Course
    {
        private int duration;

        public RegularCourse(string name, int hours, int duration) : base(name, hours)
        {
            this.duration = duration;
        }

        public override void CourseInfo()
        {
            Console.WriteLine("{0} {1} годин (тривалість: {2} місяці)", name, hours, duration);
        }
    }
}
