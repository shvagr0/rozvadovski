using System;

namespace HomeWork
{

    class TTriangle
    {
        private double a;
        private double b;
        private double c;

        public TTriangle()
        {

        }

        public TTriangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public TTriangle(TTriangle rectangle)
        {
            this.a = rectangle.a;
            this.b = rectangle.b;
            this.c = rectangle.c;
        }

        public double area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double perimetr()
        {
            return (a + b + c);
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c} (area = {area()}; perimetr = {perimetr()})";
        }

        public static TTriangle operator +(TTriangle t1, TTriangle t2)
        {
            return new TTriangle(t1.a + t2.a, t1.b + t2.b, t1.c + t2.c);
        }

        public static TTriangle operator -(TTriangle t1, TTriangle t2)
        {
            return new TTriangle(t1.a - t2.a, t1.b - t2.b, t1.c - t2.c);
        }

        public static TTriangle operator *(TTriangle t, double x)
        {
            return new TTriangle(t.a * x, t.b * x, t.c * x);
        }
    }

    class TSquare
    {
        private double a;

        public TSquare()
        {

        }

        public TSquare(double a)
        {
            this.a = a;
        }

        public TSquare(TSquare square)
        {
            this.a = square.a;
        }

        public double area()
        {
            return a * a;
        }

        public double perimetr()
        {
            return a * 4;
        }

        public override string ToString()
        {
            return $"a = {a}, (area = {area()}; perimetr = {perimetr()})";
        }

        public static TSquare operator +(TSquare s1, TSquare s2)
        {
            return new TSquare(s1.a + s2.a);
        }

        public static TSquare operator -(TSquare s1, TSquare s2)
        {
            return new TSquare(s1.a - s2.a);
        }

        public static TSquare operator *(TSquare s, double x)
        {
            return new TSquare(s.a * x);
        }
    }

    class TRectangle
    {
        private double a;
        private double b;

        public TRectangle()
        {

        }

        public TRectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public TRectangle(TRectangle square)
        {
            this.a = square.a;
            this.b = square.b;
        }

        public double area()
        {
            return a * b;
        }

        public double perimetr()
        {
            return a * 2 + b * 2;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b} (area = {area()}; perimetr = {perimetr()})";
        }

        public static TRectangle operator +(TRectangle s1, TRectangle s2)
        {
            return new TRectangle(s1.a + s2.a, s1.b + s2.b);
        }

        public static TRectangle operator -(TRectangle s1, TRectangle s2)
        {
            return new TRectangle(s1.a - s2.a, s1.b - s2.b);
        }

        public static TRectangle operator *(TRectangle s, double x)
        {
            return new TRectangle(s.a * x, s.b * x);
        }
    }

    class Program
    {
        static void Main()
        {
            TTriangle triangle1 = new TTriangle(12, 15.3, 12.1);
            TTriangle triangle2 = new TTriangle(10.2, 8.9, 9);

            TTriangle triangle3 = triangle1 + triangle2;
            Console.WriteLine(triangle3);

            TTriangle triangle4 = triangle1 - triangle2;
            Console.WriteLine(triangle4);

            TTriangle triangle5 = triangle1 * 2.5;
            Console.WriteLine(triangle5);

            Console.WriteLine();
            //---------------------------------------------------------------

            TSquare square1 = new TSquare(14.34);
            TSquare square2 = new TSquare(12.3);

            TSquare square3 = square1 + square2;
            Console.WriteLine(square3);

            TSquare square4 = square1 - square2;
            Console.WriteLine(square4);

            TSquare square5 = square1 * 0.78;
            Console.WriteLine(square5);

            Console.WriteLine();
            //---------------------------------------------------------------

            TRectangle rectangle1 = new TRectangle(15.7, 8.87);
            TRectangle rectangle2 = new TRectangle(9, 5.5);

            TRectangle rectangle3 = rectangle1 + rectangle2;
            Console.WriteLine(rectangle3);

            TRectangle rectangle4 = rectangle1 - rectangle2;
            Console.WriteLine(rectangle4);

            TRectangle rectangle5 = rectangle1 * 7.1;
            Console.WriteLine(rectangle5);
        }
    }

}

