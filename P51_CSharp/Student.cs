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


        //// #1, 2, 3
        //public void Exam(string date)
        //{
        //    Console.WriteLine($"Для студента {FirstName} {LastName} на {date} назначено іспит");
        //}

        ///// #4
        public void Exam(object sender, ExamEventArgs args)
        {
            Teacher t = sender as Teacher;
            Console.WriteLine($"{t.Name} назнчив для {LastName} {FirstName} іспит з {args.Subject}, " +
                $"який пройде {args.Date} в кабінеті {args.Room}");
        }

    }

    //public delegate void ExamDelegate(string s);

    public class ExamEventArgs : EventArgs
    {
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string Room { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }

        /// #1
        //Action<string> exam;

        //public void SetMethod(Action<string> m)
        //{
        //    exam += m;
        //}

        //public void DelMethod(Action<string> m)
        //{
        //    exam -= m;
        //}

        //// #2
        //public event ExamDelegate ExamEvent;

        //// #3
        //public event Action<string> ExamEvent;

        SortedList<Student, EventHandler<ExamEventArgs>> methodList = 
            new SortedList<Student, EventHandler<ExamEventArgs>>(new DateComparer());

        //// #4, #5 - povna forma
        public event EventHandler<ExamEventArgs> ExamEvent
        {
            add 
            {
                Student s = value.Target as Student;
                methodList.Add(s, value);
            }
            remove 
            {
                Student s = value.Target as Student;
                methodList.Remove(s);
            }
        }

        public void SetExam(ExamEventArgs args)
        {
            Console.WriteLine($"Викладач назначив іспит на {args.Date}");

            //// #2, 3
            //if(ExamEvent != null)
            //{
            //    ExamEvent(date);
            //}


            ///// #1
            //if (exam != null)
            //{
            //    foreach (Action<string> item in exam.GetInvocationList())
            //    {
            //        item(date);
            //    }
            //}

            ///// #4
            //if(ExamEvent != null)
            //{
            //    ExamEvent(this, args);
            //}

            //// #5
            foreach (Student item in methodList.Keys)
            {
                methodList[item](this, args);
            }
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
