using System;

namespace Stuffs
{
    class Program
    {
        public static int Addition( int x, int y)
        {
            return x + y;
        }

        public static int Substraction(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static double Division(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Addition(2,3));
            Console.WriteLine(Substraction(2,3));
            Console.WriteLine(Multiplication(2,3));
            Console.WriteLine(Division(2,3));
        }
    }
}
