using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var numbers = new[] { 1, 2, 3 };
            //Console.WriteLine(numbers[1]);

            //Change(numbers);
            //Console.WriteLine(numbers[1]);

            //var result = numbers;
            //result[1] = 1;
            //Console.WriteLine(numbers[1]);

            var a = 4;
            var b = a;
            b = 2;
            Console.WriteLine(a);

            var value = 3d;
            value = null;

            var reference = string.Empty;
            reference = null;

            Nullable<double> nullable = 3d;
            nullable = 3.0 / 2;
            nullable = null;

            if (nullable.HasValue)
            {
                Console.WriteLine(nullable.Value);
            }
        }

        private static void Change(int[] numbers)
        {
            numbers[1] = 4;
        }
    }
}
