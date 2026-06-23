using System.Text;

namespace P51_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P51 C#";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            //23.06.2026


            //Point point  = new Point();
            //point.X = 10;
            //point.Y = 30;
            //point.Print();

            //int? a = null;

            Console.WriteLine(Student.GetAcademy());
            Student student = new Student();
            student.Print();
            Console.WriteLine(Student.number_of_years_study);
            Console.WriteLine(student.number_of_subject);
            
            //student.number_of_subject = 7;
                        
            //Student.SetAcademy("University NUK");
            
            Student student1 = new Student(1, "Vasya", "Pupkin", new DateOnly(2000, 1, 20), 8);
            student1.Print();
            


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
