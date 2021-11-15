using System;

namespace variant1_6_11
{
    struct Student
    {
        public string name;
        public string surname;
        public string group;
        public int year;
        public Result[] results;

        public Student(string name, string surname, string group, int year, Result[] results)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.year = year;
            this.results = results;
        }

        public int GetAveragePoints()
        {
            int sum = 0;
            int avg;
            for (int i = 0; i < results.Length; i++)
            {
                sum += results[i].points;
            }
            return avg = sum / results.Length;
        }

        public string GetBestSubject()
        {
            int bestindex = 0;
            int max = 0;
            for (int i = 0; i < results.Length; i++)
            {
                if (max < results[i].points)
                {
                    max = results[i].points;
                    bestindex = i;
                }
            }
            return results[bestindex].subject;
        }

        public string GetWorstSubject()
        {
            int wrostindex = 0;
            int min = 100;
            for (int i = 0; i < results.Length; i++)
            {
                if (min > results[i].points)
                {
                    min = results[i].points;
                    wrostindex = i;
                }
            }
            return results[wrostindex].subject;
        }
    }
}
