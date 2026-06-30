using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point() : this(0, 0) { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"(X = {X}, Y = {Y})");
        }

        public static Point operator -(Point p)
        {
            return new Point(-p.X, -p.Y);
        }

        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator +(Point p1, int n)
        {
            return new Point(p1.X + n, p1.Y + n);
        }

        public static Point operator +(int n, Point p1)
        {
            return new Point(p1.X + n, p1.Y + n);
        }


        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) > Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) < Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0; 
        }


        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
        }

        public static Point operator |(Point p1, Point p2)
        {
            return new Point(p1.X, p1.Y); // bred
        }

        public static /*explicit*/ implicit operator float(Point p)
        {
            return (float)Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

    }
}
