using System;

namespace tema17
{
    class InvalidTimeFormatException : Exception
    {
        public InvalidTimeFormatException() : base()
        {
            Console.WriteLine("InvalidTimeFormatException");
        }
    }
    class Time
    {
        public int hours;
        public int minutes;

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public override string ToString()
        {
            string h, m;
            if (hours < 10)
            {
                h = "0" + hours.ToString();
            }
            else
            {
                h = hours.ToString();
            }
            if (minutes < 10)
            {
                m = "0" + minutes.ToString();
            }
            else
            {
                m = minutes.ToString();
            }
            return $"{h}:{m}";
        }
    }

    class Program
    {

        static public Time ConvertFromIntToTime(int time)
        {
            if (time > 1440) //якщо ми передамо число більше за 1440 то виникне помилка (1441 to Time = 24:01(такої години немає))
            {
                throw new InvalidTimeFormatException();
            }
            else
            {
                try
                {
                    int hours = time / 60;
                    int minutes = time % 60;
                    return new Time(hours, minutes);
                }
                catch (InvalidTimeFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    return new Time(0, 0);
                }
            }
        }

        static void Main(string[] args)
        {

            try
            {
                Time time = ConvertFromIntToTime(int.Parse(Console.ReadLine())); //строка в якій може виникнути потенційна помилка
                Console.WriteLine(time);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // код, який має бути виконаний у будь-якому випадку
                Console.WriteLine("Good By!");
            }
        }

    }
}
