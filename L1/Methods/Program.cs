using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(5, 3));
            Console.WriteLine(Pow(5, 0));
            Console.WriteLine(Pow(0, 0));
        }

        static int Pow(int value, int degree)
        {
            var result = 1;

            for (int i = 0; i < degree; i++)
            {
                result *= value;
            }

            return result;
        }
    }
}
