using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    internal class Point2D<T> /*where T : struct*/ /*class,*/ /*IComparable,*/ /*Human, new()*/
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }


        public Point2D()
        {
            X = default;
            Y = default;
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }

    class Point3D<T> : Point2D<T>
    {
        public T Z { get; set; }
        public Point3D(T x, T y, T z) : base(x, y)
        {
            Z = z;
        }
        public Point3D() : base()
        {
            Z = default;
        }
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }
    }
}
