using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{

    public class StudentCard : IComparable
    {
        public string? Series { get; set; }

        public int Number { get; set; }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }

        public int CompareTo(object? other)
        {
            StudentCard? sc = other as StudentCard;
            return (Series + Number).CompareTo(sc!.Series + sc.Number);
        }
    }

    public class Student : IComparable<Student>, ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDay { get; set; }

        public StudentCard? StudentCard { get; set; }

        public static IComparer<Student> FromBirthDay { get; } = new DateComparer();
        public static IComparer FromStudentCard { get; } = new StudentCardComparer();

        public int CompareTo(Student? st)
        {
            return (LastName + FirstName).CompareTo(st!.LastName + st.FirstName);
        }

        public override string ToString()
        {
            return $"{LastName,-20} {FirstName,-15} {BirthDay} {StudentCard}";
        }

        public object Clone()
        {
            Student clonedStudent = (Student)this.MemberwiseClone();
            clonedStudent.StudentCard = new StudentCard
            {
                Series = this.StudentCard?.Series,
                Number = this.StudentCard!.Number
            };
            return clonedStudent;
        }

        public override int GetHashCode()
        {
            return $"{FirstName}{LastName}{BirthDay}{StudentCard.Series}{StudentCard.Number}".GetHashCode();
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

    public class DateComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.BirthDay.CompareTo(y.BirthDay);
        }
    }

    public class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student)
            {
                return ((Student)x).StudentCard!.CompareTo(((Student)y).StudentCard);
            }
            throw new NotImplementedException();
        }
    }
}
