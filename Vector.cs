using System;

namespace GeoVector
{
    class geovector
    {
        public static double ToRadian(double angle)
        {
            return angle * Math.PI / 180;
        }

        public static double ToDegree(double radian)
        {
            return radian * 180 / Math.PI;
        }

        public class Vector
        {
            public double direction; //360
            public double magnitude;

            public Vector(double dir, double mag)
            {
                this.direction = dir;
                this.magnitude = mag;
            }

            public Vector2 ToVector2()
            {
                double sineDir = Math.Sin(ToRadian(this.direction));

                double x = Math.Sqrt(Math.Pow(this.magnitude, 2) - Math.Pow(sineDir, 2));
                double y = magnitude * sineDir;
                Vector2 temp = new Vector2(x, y);
                return temp;
            }

            public static Vector operator *(double left, Vector right)
            {
                return new Vector(right.direction, right.magnitude * left);
            }

            public static Vector operator *(Vector left, double right)
            {
                return new Vector(left.direction, left.magnitude * right);
            }

            // 내적
            public static double operator *(Vector a, Vector b)
            {
                double angle = Math.Abs(a.direction - b.direction);
                return Math.Cos(ToRadian(angle)) * a.magnitude * b.magnitude;
            }

            public static Vector operator /(Vector left, double right)
            {
                return left * (1 / right);
            }

            public static Vector operator /(double left, Vector right)
            {
                return right * (1 / left);
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

            public static Vector2 operator -(Vector2 a)
            {
                return new Vector2(-a.x, -a.y);
            }

            public static Vector2 operator +(Vector2 a, Vector2 b)
            {
                return new Vector2(a.x + b.x, a.y + b.y);
            }

            // 실수배

            public static Vector2 operator *(double left, Vector2 right)
            {
                return new Vector2(left * right.x, left * right.y);
            }

            public static Vector2 operator *(Vector2 left, double right)
            {
                return new Vector2(left.x * right, left.y * right);
            }

            // 내적
            public static double operator *(Vector2 a, Vector2 b)
            {
                return a.x * b.x + a.y * b.y;
            }

            public static Vector2 operator /(Vector2 left, double right)
            {
                return left * (1 / right);
            }

            public static Vector2 operator /(double left, Vector2 right)
            {
                return right * (1 / left);
            }

            public static Vector2 operator -(Vector2 a, Vector2 b)
            {
                return a + -b;
            }

            // 수직 operator
            public static bool operator ^(Vector2 a, Vector2 b)
            {
                return (a*b == 0);
            }

            public static bool operator ==(Vector2 a, Vector2 b)
            {
                return (a.x == b.x && a.y == b.y);
            }

            public static bool operator !=(Vector2 a, Vector2 b)
            {
                return (a.x != b.x || a.y != b.y);
            }

            // 크기
            public double Magnitude()
            {
                return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            }
            
            // static 크기. b-a의 크기를 구함.
            public static double Magnitude(Vector2 a, Vector2 b)
            {
                return (b - a).Magnitude();
            }

            public static Vector2 InternalDivision(Vector2 a, Vector2 b, double leftRatio, double rightRatio)
            {
                return (a * rightRatio + b * leftRatio) / (leftRatio + rightRatio);
            }

            public static Vector2 ExternalDivision(Vector2 a, Vector2 b, double leftRatio, double rightRatio)
            {
                return (a * rightRatio - b * leftRatio) / (leftRatio - rightRatio);
            }

            // 
            public Vector ToVector()
            {
                return new Vector(1, this.Magnitude());
            }

            public override string ToString()
            {
                return "(" + this.x.ToString() + ", " + this.y.ToString() + ")";
            }
        };

        public static void test()
        {
            Vector2 a = new Vector2(1, 2);
            Vector2 b = new Vector2(2, 3);
            Console.WriteLine("a = " + a.ToString());
            Console.WriteLine("b = " + b.ToString());
            Console.WriteLine("a+b = " + (a+b).ToString());
            double naejuck = a*b;
            Console.WriteLine("a*b = " + naejuck.ToString());
        }
    }
}   