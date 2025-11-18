using System;

namespace geovector
{
    class Program
    {
        public class Vector
        {
            public double direction;
            public double magnitude;

            public Vector2 ToVector2()
            {
                Vector2 temp = new Vector2(1, 1);
                return temp;
            }
        }

        public class Vector2
        {
            public double x;
            public double y;

            public Vector2(double X, double Y)
            {
                this.x = X;
                this.y = Y;
            }

            public Vector ToVector()
            {
                Vector temp = new Vector();
                return temp;
            }

            public static Vector2 operator +(Vector2 a, Vector2 b)
            {
                return new Vector2(a.x + b.x, a.y + b.y);
            }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}   