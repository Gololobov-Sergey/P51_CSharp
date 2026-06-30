using System.Drawing;
using System.Text;

namespace P51_CSharp
{
    internal class Program
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

        static void Main(string[] args)
        {
            Console.Title = "P51 C#";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();


            //30.06.2026

            // =


            // + += , - , *, /, % 
            // ! < > >= <= == != 


            Point p1 = new Point(2, 4);
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



            Apple a1 = new Apple(ConsoleColor.Green, 15);
            Apple a2 = new Apple(ConsoleColor.Red, 10);
            Kompot k = a1 + a2;
            Apple a3 = new Apple(ConsoleColor.Yellow, 13);
            k += a3;
            k.Print();
            k += new Ingradient("Water", 1000);
            k += new Ingradient("Sugar", 100);

            k.Print();

            Console.WriteLine(ConsoleColor.Red);


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
