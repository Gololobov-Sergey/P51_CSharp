using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    internal partial class Program
    {
        static void PrintGroup(Hashtable group)
        {
            foreach (Student item in group.Keys)
            {
                Console.Write($"{item.FirstName} {item.LastName} - ");
                var marks = (ArrayList)group[item];
                foreach (var mark in marks)
                {
                    Console.Write($"{mark} ");
                }
                Console.WriteLine();
            }
        }

        private static void AddMark(Hashtable group, string fn, string ln, int mark)
        {
            foreach (Student item in group.Keys)
            {
                if (item.FirstName == fn && item.LastName == ln)
                {
                    var marks = (ArrayList)group[item];
                    marks.Add(mark);
                    return;
                }
            }
        }


        static T MaxValue<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
