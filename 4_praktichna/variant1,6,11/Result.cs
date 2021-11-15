using System;

namespace variant1_6_11
{
    struct Result
    {
        public string subject;
        public string teacher;
        public int points;

        public Result(string subject, string teacher, int points)
        {
            this.subject = subject;
            this.teacher = teacher;
            this.points = points;
        }
    }
}
