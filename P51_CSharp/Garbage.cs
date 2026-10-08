using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    internal class Garbage
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Student s = new Student();
            }
        }
    }
}
