namespace P51_CSharp
{
    public class Apple
    {
        
        public ConsoleColor Color { get; }
        public int Weight { get; }

        public Apple(ConsoleColor color, int weight)
        {
            Color = color;
            Weight = weight;
        }

        public static Kompot operator+(Apple a1, Apple a2)
        {
            return new Kompot(); //....
        }

    }

    public class Kompot
    {
        internal void Print()
        {
            throw new NotImplementedException();
        }

        public static Kompot operator+ (Kompot k, Apple a)
        {
            return new Kompot(); // .....
        }

        public static Kompot operator+(Kompot k, Ingradient i)
        {
            return new Kompot(); //....
        }

    }

    public class Ingradient
    {
        public string Name { get; }

        public int Weight { get; }

        public Ingradient(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}