using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array3 = { 1, 2, 3, 4, 5, 6 };

            //var c = array3[1];
            //Console.WriteLine(array3[0]);


            //int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(multiDimensionalArray2[0, 2]);

            //var numbers = new int[100];
            //var random = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    numbers[i] = random.Next(500);
            //}
            var numbers = new[] { 1, 4, 6, 3, 5 };



            Console.WriteLine(Min(numbers));
            Console.WriteLine(Max(numbers));
            Console.WriteLine(Average(numbers));
            Console.WriteLine(Median(numbers));
        }

        private static double? Median(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return null;
            }

            numbers = numbers.OrderBy(e => e)
                             .ToArray();

            // Try it
            // 10 -> 10-1/2,10/2
            // 9 -> 9-1/2,9/2

            var length = numbers.Length;
            if (length % 2 == 0)
            {
                return ((double)(numbers[length / 2] + numbers[length / 2 - 1]) / 2);
            }
            else
            {
                return numbers[length / 2];
            }
        }

        private static double? Average(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return null;
            }

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }

        private static int? Max(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return null;
            }

            var result = int.MinValue;
            foreach (var number in numbers)
            {
                result = Math.Max(result, number);
            }

            return result;
        }

        private static int Min(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Collection is empty.");
            }

            var result = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }

            return result;
        }
    }
}
