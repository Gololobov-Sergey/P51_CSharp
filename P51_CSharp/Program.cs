using System.Collections;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Security.Cryptography;
using static P51_CSharp.Program;

namespace P51_CSharp
{
    internal partial class Program
    {

        static void MyFunc(ref int[] arr, ref int a, out int b)
        {
            arr[0] = 999;
            arr = new int[] { 4, 5, 6 };
            a = 100;
            b = 999;
        }

        static int Sum(params int[] arr)
        {
            int s = 0;
            foreach (int i in arr)
            {
                s += i;
            }

            return s;
        }

        static int Div(int a, int b)
        {
            //try
            //{
            //    if (b == 0)
            //        throw new DivideByZeroException("Oops");
            //    return a / b;
            //}
            //catch (Exception ex)
            //{
            //    throw; // new Exception("Div by zero", ex);
            //}


            if (b != 0)
                return a / b;
            throw new ArgumentNullException("b = 0");

        }

        static void DoWork(IManager worker)
        {
            worker.Manage();
        }

        public delegate void MyDelegate(string message);

        //public delegate int CalcDelegate(int a, int b);

        //public delegate double CalcDoubleDelegate(double a, double b);

        public delegate TOut Calc_T_Delegate<TOut, T1, T2>(T1 a, T2 b);

        //public delegate void Universal<T1, T2>(T1 a, T2 b);
        //public delegate void Universal<T1, T2, T3>(T1 a, T2 b, T3 c);

        static public void UFunc(int a, float b)
        {
            Console.WriteLine("UFanc");
        }

        static public void PrintStudent(Student st)
        {
            Console.WriteLine($"{st.FirstName} {st.BirthDay}");
        }


        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.Title = "P51 C#";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            //24.09.2026

            List<Student> students = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Doe", BirthDay = new DateOnly(2000, 1, 10), StudentCard = new StudentCard { Series = "AB", Number = 123456 } },
                new Student { FirstName = "Jane", LastName = "Smith", BirthDay = new DateOnly(2000, 1, 2), StudentCard = new StudentCard { Series = "AB", Number = 123455 } },
                new Student { FirstName = "Alice", LastName = "Johnson", BirthDay = new DateOnly(2001, 3, 3), StudentCard = new StudentCard { Series = "AA", Number = 123458 } },
                new Student { FirstName = "Bob", LastName = "Brown", BirthDay = new DateOnly(2000, 4, 4), StudentCard = new StudentCard { Series = "AA", Number = 123457 } }
            };

            


            Teacher teacher = new Teacher { Name = "Gololobov S.A."};

            foreach (Student item in students)
            {
                teacher.ExamEvent += item.Exam;
            }

            //teacher.ExamEvent += Teacher_ExamEvent;

            //.....

            teacher.SetExam(new ExamEventArgs { Date = new DateTime(2026, 10, 20), Subject = "C#", Room = "208"});

            teacher.ExamEvent -= students[2].Exam;

            Console.WriteLine();
            teacher.SetExam(new ExamEventArgs { Date = new DateTime(2026, 10, 24), Subject = "C#", Room = "205" });

            //teacher.SetMethod(students[2].Exam);

            Console.WriteLine();
            teacher.SetExam(new ExamEventArgs { Date = new DateTime(2026, 10, 30), Subject = "C#", Room = "210" });


            //22.09.2026


            //List<Student> students = new List<Student>
            //{
            //    new Student { FirstName = "John", LastName = "Doe", BirthDay = new DateOnly(2000, 1, 10), StudentCard = new StudentCard { Series = "AB", Number = 123456 } },
            //    new Student { FirstName = "Jane", LastName = "Smith", BirthDay = new DateOnly(2000, 1, 2), StudentCard = new StudentCard { Series = "AB", Number = 123455 } },
            //    new Student { FirstName = "Alice", LastName = "Johnson", BirthDay = new DateOnly(2001, 3, 3), StudentCard = new StudentCard { Series = "AA", Number = 123458 } },
            //    new Student { FirstName = "Bob", LastName = "Brown", BirthDay = new DateOnly(2000, 4, 4), StudentCard = new StudentCard { Series = "AA", Number = 123457 } }
            //};

            //Console.WriteLine(students.All(s => s.BirthDay.Year < 2002));

            //Console.WriteLine(students.Count(s => s.BirthDay.Year == 2000));

            //PrintStudent(students.Last(s => s.BirthDay.Month == 1));

            //var st = students.Select(s => new { s.FirstName, s.LastName }).ToList();
            //st.ForEach(s => Console.WriteLine(s));

            //Console.WriteLine(students[0].GetHashCode());


            //students.FindAll(s => s.BirthDay.Month >= 3 && s.BirthDay.Month <= 5).ForEach(PrintStudent);


            //students.Sort(new DateComparer());
            //students.Sort((s1, s2) => s1.BirthDay.CompareTo(s2.BirthDay));

            //students.ForEach(s => Console.WriteLine(s));

            //SHA512 sha512 = SHA512.Create();
            //var b = sha512.   ComputeHash(Encoding.UTF8.GetBytes(students[0].ToString()));
            //string st1 = Encoding.UTF8.GetString(b);
            //Console.WriteLine(st1);

            //students.ForEach(PrintStudent);
            //students.ForEach(s => Console.WriteLine($"{s.FirstName} {s.BirthDay}"));

            //Action<Student> printName = s => Console.WriteLine($"{s.FirstName} {s.BirthDay}");
            //foreach (Student item in students)
            //{
            //    printName(item);
            //}

            //Universal<int, float> universal = UFunc; // ???

            //Action<int, float> action = UFunc;



            //MyDelegate myDelegate = PrintMessage;
            //myDelegate("Hello World!");

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            ////char op = Convert.ToChar(Console.ReadLine());

            //Calc calc = new Calc();
            //Calc_T_Delegate<int> calcDelegate = calc.Add;
            //calcDelegate += calc.Multiply;
            //calcDelegate += Calc.Subtract;

            //Console.WriteLine(calcDelegate(a, b));

            //Calc_T_Delegate<int> calc1 = calc.Add;

            //((Calc)calc1.Target).Show();

            //foreach (CalcDelegate item in calcDelegate.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}
            //Console.WriteLine();

            //calcDelegate -= Calc.Subtract;
            //foreach (CalcDelegate item in calcDelegate.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}
            //Console.WriteLine();

            //Console.WriteLine(((CalcDelegate)calcDelegate.GetInvocationList()[1])(a, b));

            //switch (op)
            //{
            //    case '+':
            //        calcDelegate = calc.Add;
            //        break;
            //    case '-':
            //        calcDelegate = Calc.Subtract;
            //        break;
            //    case '*':
            //        calcDelegate = calc.Multiply;
            //        break;
            //    default:
            //        break;
            //}

            //int res = calcDelegate(a, b);
            //Console.WriteLine(res);

            //17.09.2026


            //Point2D<Employee> point1 = new Point2D<Employee>();
            //Console.WriteLine(point1);



            //Iter iter = new Iter();
            //foreach (int item in iter.GetEvenEnumerator())
            //{
            //    Console.WriteLine(item);
            //}


            //Alphabet alphabet = new Alphabet();
            //foreach (char item in alphabet)
            //{
            //    Console.Write(item);
            //}


            //Hashtable group = new Hashtable
            //{
            //    {
            //        new Student { FirstName = "John", LastName = "Doe", 
            //            BirthDay = new DateOnly(2000, 1, 10), 
            //            StudentCard = new StudentCard { Series = "AB", Number = 123456 } },
            //        new ArrayList{10,11,12}
            //    },
            //    {
            //        new Student { FirstName = "Jane", LastName = "Smith", 
            //            BirthDay = new DateOnly(2000, 1, 2), 
            //            StudentCard = new StudentCard { Series = "AB", Number = 123455 } },
            //        new ArrayList{9,10,11}
            //    },
            //    {
            //        new Student { FirstName = "Alice", LastName = "Johnson", 
            //            BirthDay = new DateOnly(2001, 3, 3), 
            //            StudentCard = new StudentCard { Series = "AA", Number = 123458 } },
            //        new ArrayList{12,12,12}
            //    },
            //    {
            //        new Student { FirstName = "Bob", LastName = "Brown", 
            //            BirthDay = new DateOnly(2000, 4, 4), 
            //            StudentCard = new StudentCard { Series = "AA", Number = 123457 } },
            //        new ArrayList{8,9,10}
            //    }
            //};

            //PrintGroup(group); //Vasya Pupkin - 10, 12, 12

            //AddMark(group, "Bob", "Brown", 12);

            //PrintGroup(group);


            //using(new OperationTimer("ArrayList"))
            //{
            //    ArrayList arr = new ArrayList();
            //    for (int i = 0; i < 10000000; i++)
            //    {
            //        arr.Add(i);
            //        int x = (int)arr[i];
            //    }
            //    arr = null;
            //}

            //using(new OperationTimer("List<int>"))
            //{
            //    List<int> arr = new List<int>();
            //    for (int i = 0; i < 10000000; i++)
            //    {
            //        arr.Add(i);
            //        int x = arr[i];
            //    }
            //    arr = null;
            //}

            //15.09.2026


            //Warriror warriror = new Warriror();
            //warriror.SetWeapon(new Sword());
            //warriror.Attack();

            //warriror.SetWeapon(new Gun());
            //warriror.Attack();


            //List<IWorker> team = [new TeamLead(), new Worker(), new Worker(), new Worker()];
            //foreach (IWorker item in team)
            //{
            //    item.Work();
            //}


            //Student student1 = new Student() { FirstName = "Vasya", LastName = "Pupkin", BirthDay = new DateOnly(2000, 05, 15), StudentCard = new StudentCard() { Series = "AA", Number = 123456 } };
            //Student student2 = (Student)student1.Clone();

            //Console.WriteLine(student1);
            //Console.WriteLine(student2);

            //student2.FirstName = "Petya";
            //student2.StudentCard.Number = 999999;

            //Console.WriteLine(student1);
            //Console.WriteLine(student2);


            //Child child1 = new Child() { Name = "Vasya", Age = 10 };
            //Child child2 = (Child)child1.Clone();

            //Console.WriteLine(child1);
            //Console.WriteLine(child2);

            //child2.Name = "Petya";

            //Console.WriteLine(child1);
            //Console.WriteLine(child2);

            //10.09.2026


            //Group group = new Group();
            //foreach (Student item in group)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            ////group.Sort(new DateComparer());
            ////group.Sort(Student.FromBirthDay);
            //group.Sort(Student.FromStudentCard);
            //foreach (Student item in group)
            //{
            //    Console.WriteLine(item);
            //}


            //MyClass2 my = new MyClass2();
            //my.Show();

            //((IA)my).Show();

            //IA a = new MyClass2();
            //a.Show();

            //IB b = new MyClass2();
            //b.Show();

            //IC c = new MyClass2();
            //c.Show();


            //Employee employee = new Employee(1, "Petrik", "Pyatochkin", 1000);
            //employee.Work();

            //Programmer programmer = new Programmer(1, "Vovka", "Zhirok", "C#");
            //programmer.Work();



            //IWorker prorab = new Prorab();
            //prorab.Work();

            //prorab.IsWorking = true;
            //prorab.Work();

            //Director2 dir = new Director2() { IsWorking = true };
            //dir.Work();
            //dir.Manage();


            //DoWork(dir);
            //DoWork(prorab);

            //08.09.2026


            //Human human = new Human(1, "Vasya", "Pupkin");
            //human.ShowHuman();
            //Console.WriteLine();

            //Employee employee = new Employee(1, "Petrik", "Pyatochkin", 1000);
            //employee.Print();
            //employee.ShowEmployee();
            //Console.WriteLine();

            //Director director = new Director(1, "Vovka", "Zhirok", 1000, 2000);
            //director.Print();
            //director.ShowDirector();
            //Console.WriteLine();

            //Human[] h = new Human[] {/* human,*/ employee, director };

            //foreach (Human item in h)
            //{
            //    //item.Print();

            //    Console.WriteLine(item);

            //    //item.ShowHuman();

            //    //try
            //    //{
            //    //    ((Employee)item).ShowEmployee();
            //    //}
            //    //catch (Exception)
            //    //{

            //    //}



            //    //Employee e = item as Employee;
            //    //if(e != null)
            //    //{
            //    //    e.ShowEmployee();
            //    //}

            //    //if(item is Director dir)
            //    //{
            //    //    dir.ShowDirector();
            //    //}
            //}






            //02.07.2026


            //Matrix m1 = new Matrix(3, 2);


            //m1.SetRandom(2, 5);
            //m1.Print();

            ////Matrix m2 = new Matrix { Rows = 2, Cols = 4 };
            //Matrix m2 = new Matrix(2, 3);
            //m2.SetRandom(3, 6);
            //m2.Print();

            //Matrix m3 = m1 * m2;
            //m3.Print();

            //Matrix m4 = new Matrix(3, 2);
            //m4.SetRandom(2, 7);
            //m4.Print();

            //Matrix m5 = m1 + m4;
            //m5.Print();

            //m1[1, 1] = 100;
            //Console.WriteLine(m1[1,1]);

            //string s = "mama";
            //s += "papa";

            //Temperature t = new Temperature(20);
            //Console.WriteLine(t.Celsius + " °C");
            //Console.WriteLine(t.Kelvin + " °K");
            //Console.WriteLine(t["Kelvin"]);



            //30.06.2026

            // =


            // + += , - , *, /, % 
            // ! < > >= <= == != 


            //Point p1 = new Point(2, 4);
            //Console.WriteLine(p1["X"]);
            //Console.WriteLine(p1[1]);
            //Point p2 = new Point(2, 4);
            //Point p3 = p1 + p2;
            //p1 += p3;
            //Point p4 = -p1;
            //p1++;
            //++p1;
            //p1.Print();
            //p1 = p2 + 10;
            //p1 = 10 + p2;


            //Point p5 = p1;
            //p1++;
            //p1.Print();
            //p5.Print();

            //if(p1 || p5)
            //{

            //}

            //float f = p1;



            //Apple a1 = new Apple(ConsoleColor.Green, 15);
            //Apple a2 = new Apple(ConsoleColor.Red, 10);
            //Kompot k = a1 + a2;
            //Apple a3 = new Apple(ConsoleColor.Yellow, 13);
            //k += a3;
            //k.Print();
            //k += new Ingradient("Water", 1000);
            //k += new Ingradient("Sugar", 100);

            //k.Print();

            //Console.WriteLine(ConsoleColor.Red);


            //25.06.2026

            //// open file
            //try
            //{
            //    //work with file
            //    //int a = Convert.ToInt32(Console.ReadLine());
            //    //int b = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine(Div(a,b));

            //    string s = Console.ReadLine();

            //    int[] arr = { 1, 2, 3 };
            //    Console.WriteLine(arr[3]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.HelpLink);
            //    Console.WriteLine(ex.HResult);
            //    Console.WriteLine(ex.InnerException);
            //}
            //finally
            //{
            //    //close file 
            //}





            //Student student = new Student 
            //{ 
            //    FirstName = "Vasya", 
            //    LastName = "Pupkin", 
            //    BirthDay = new DateOnly(2000, 05, 15) 
            //};
            //student.Print();
            //Student student1 = new Student();
            //student1.Print();


            //Student2 student1 = new Student2(1, "Vasya", "Pupkin", new DateOnly(2000, 1, 20), 8);
            //student1.MyProperty = 10;
            //student1.SetID(10);
            //int id1 = student1.GetID();
            //int id2 = student1.MyProperty;
            ////student1.MyProperty1 = 22;
            //Console.WriteLine(student1.MyProperty2);


            //Temperature t = new Temperature(20);
            //Console.WriteLine(t.Celsius + " °C");
            //Console.WriteLine(t.Kelvin + " °K");
            //Console.WriteLine(t.Fahrenheit + " °F");
            //t.Kelvin = 300;
            //t.Fahrenheit = 68.6f;


            //23.06.2026


            //string[] n = { "ertger", "lkoiuoi", "lkplklk" };
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(string.Join(", ", arr));


            //int[] arr = { 1, 2, 3 };
            //int a = 9;

            //MyFunc(ref arr, ref a, out int b);
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(Sum(1,2,3,45,6));


            //Point point  = new Point();
            //point.X = 10;
            //point.Y = 30;
            //point.Print();

            //int? a = null;

            //Console.WriteLine(Student.GetAcademy());
            //P51_CSharp.Student student = new Student();
            //student.Print();
            //Console.WriteLine(Student.number_of_years_study);
            //Console.WriteLine(student.number_of_subject);


            ////student.number_of_subject = 7;

            ////Student.SetAcademy("University NUK");

            //Student student1 = new Student(1, "Vasya", "Pupkin", new DateOnly(2000, 1, 20), 8);
            //student1.Print();
            //Console.WriteLine(string.Join(", ", student1.marks));
            //student1.marks[0] = 13;
            ////student1.marks = new int[] { 12, 12, 12 };
            //Console.WriteLine(string.Join(", ", student1.marks));


            //18.06.2026


            //String s1 = "mama r2po3iuo2i3u o2i3 uo23i uo23iu  o2iuo23ir       pop2o3i";
            //var dd = s1.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //foreach (var item in dd)
            //{
            //    Console.WriteLine( item);
            //}

            //String s2 = "papa";
            //s1 += s2;

            //Random rnd = new Random();



            //int[] arr = { 1, 2, 4, 3, 1, 4, 5, 6, 3, 4 };

            //int even = Array.FindAll(arr, e => e % 2 == 0).Length;
            //int odd = arr.Length - even;

            //Console.WriteLine(arr.Distinct().ToArray().Length);

            //Console.WriteLine(Array.FindAll(arr, e => e < 4).Length);

            //int count = 0;
            //int a1 = 1, a2 = 2, a3 = 4;
            //for (int i = 0; i < arr.Length - 2; i++)
            //{
            //    if (arr[i] == a1 && arr[i+1] == a2 && arr[i+2] == a3)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int[] arr2 = new int[arr.Length + 1];
            //Array.Copy(arr, arr2, arr.Length);
            //arr = arr2;
            //arr2[arr2.Length - 1] = 999;
            //Array.ForEach(arr, e => Console.Write(e + " "));
            //Console.WriteLine();


            //int[][] arr3 = new int[3][];
            //arr3[0] = new int[] { 1, 2, 3 };
            //arr3[1] = new int[] { 1, 2, -3, 4, 5 };
            //arr3[2] = new int[] { 1, 2 };


            //Console.WriteLine(arr3.Select(a => a.Min()).Min());

            //foreach (var item in arr3)
            //{
            //    min = item.Min() < min ? item.Min() : min;
            //}
            //Console.WriteLine(min);

            //int[] arr1 = new int[] { 1,2,4,5,6};

            //arr[1] = 999;

            //Console.WriteLine(arr[1]);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] *= 2;
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            //foreach (int item in arr)
            //{
            //    //item *= 2;
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(Array.Find(arr, e => e > 4));
            //var a1 = Array.FindAll(arr, e => e % 2 == 0);
            //foreach (var item in a1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            ////[](int e){ retrun e > 4;}


            //int[,] arr2 = new int[3, 2] { { 2, 3 }, { 3, 4 }, { 5, 6 } };
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //int[][] arr3 = new int[3][];
            //arr3[0] = new int[] { 1, 2, 3 };
            //arr3[1] = new int[] { 1, 2, 3, 4, 5 };
            //arr3[2] = new int[] { 1, 2 };

            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    //foreach (var item in arr3[i])
            //    //{
            //    //    Console.Write(item + " ");
            //    //}
            //    //Console.WriteLine();

            //    for (int j = 0; j < arr3[i].Length; j++)
            //    {
            //        Console.Write(arr3[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}






            //Console.SetCursorPosition(20, 10);
            //Console.WriteLine("Hello, World!");

            //int a = Convert.ToInt32(Console.ReadLine());

            //int.TryParse(Console.ReadLine(), out int b);
            //Console.WriteLine(a + b);

            //Console.WriteLine($"Summa {a} + {b} = {a + b}");

            //Console.WriteLine("Слава Україні!");

            //int a = 10;

            ////double d = 2.54;
            ////float f = (float)d;
            //bool b = true;
            //if (b)
            //{

            //}
            //else if(!b)
            //{

            //}
            //else
            //{

            //}

            //int x = a == 0 ? 2 : 5;

            //float d = 5.51f;

            //string s = "mama";

            //switch (s)
            //{
            //    case "0":
            //    case "mama":
            //        Console.WriteLine("yyy");
            //        break;
            //    default:
            //        break;
            //}


            //int errorCode = 404;

            //string message = errorCode switch
            //{
            //    200 => "OK",
            //    400 => "Bad Request",
            //    404 => "Not Found",
            //    _ => "Unknown Error" // Acts as default
            //};

            //Console.WriteLine(message);


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("mama");
            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime);
            //Console.WriteLine(dateTime.ToLongDateString());
            //Console.WriteLine(dateTime.ToShortDateString());
            //Console.WriteLine(dateTime.ToShortTimeString());


            //int a = Convert.ToInt32(Console.ReadLine());

            //int m = 0;

            //while (a > 0)
            //{
            //    m = m * 10 + a % 10;
            //    a /= 10;
            //}
            //Console.WriteLine(m);

            Console.Read();
        }

    }
}
