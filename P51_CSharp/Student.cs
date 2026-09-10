using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{

    public class StudentCard
    {
        public string? Series { get; set; }

        public int Number { get; set; }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    public class Student : IComparable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDay { get; set; }

        public StudentCard? StudentCard { get; set; }

        public static IComparer FromBirthDay { get; } = new DateComparer();

        public int CompareTo(object? st)
        {
            if (st is Student)
            {
                return (LastName + FirstName).CompareTo(((Student)st).LastName + ((Student)st).FirstName);
            }

            throw new ArgumentException("Object is not a Student");
        }

        public override string ToString()
        {
            return $"{LastName,-20} {FirstName, -15} {BirthDay} {StudentCard}";
        }
    }


    public class Group : IEnumerable
    {
        Student[] students =
        {
            new Student { FirstName = "John", LastName = "Doe", BirthDay = new DateOnly(2000, 1, 10), StudentCard = new StudentCard { Series = "AB", Number = 123456 } },
            new Student { FirstName = "Jane", LastName = "Smith", BirthDay = new DateOnly(2000, 1, 2), StudentCard = new StudentCard { Series = "AB", Number = 123455 } },
            new Student { FirstName = "Alice", LastName = "Johnson", BirthDay = new DateOnly(2001, 3, 3), StudentCard = new StudentCard { Series = "AA", Number = 123458 } },
            new Student { FirstName = "Bob", LastName = "Brown", BirthDay = new DateOnly(2000, 4, 4), StudentCard = new StudentCard { Series = "AA", Number = 123457 } }
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator(); 
        }

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }

    public class DateComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student)
            {
                return ((Student)x).BirthDay.CompareTo(((Student)y).BirthDay);
            }
            throw new ArgumentException("Objects are not Students");
        }
    }
}
