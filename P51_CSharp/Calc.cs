using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    internal class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void Show()
        {
            Console.WriteLine("Calc Show");
        }

    }
}
