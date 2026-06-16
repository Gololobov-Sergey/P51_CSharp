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


            int a = Convert.ToInt32(Console.ReadLine());

            int m = 0;

            while (a > 0)
            {
                m = m * 10 + a % 10;
                a /= 10;
            }
            Console.WriteLine(m);

            Console.Read();
        }
    }
}
