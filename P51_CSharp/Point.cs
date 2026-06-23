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
    }
}
