using System;
using System.Linq;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var number = 4;
            NumberSum(number);
            Program.NumberSum(number);

            number.NumberSumViaExtension();
            IntExtensions.NumberSumViaExtension(number);

            var stringValue = "aaa";
            Console.WriteLine(stringValue.CountOfA());

            stringValue = null;
            Console.WriteLine(stringValue.CountOfA());
        }

        public static int NumberSum(int value)
        {
            var result = 0;

            while (value != 0)
            {
                result += value % 10;
                value /= 10;
            }

            return result;
        }
    }

    public static class IntExtensions
    {
        public static int NumberSumViaExtension(this int value)
        {
            var result = 0;

            while (value != 0)
            {
                result += value % 10;
                value /= 10;
            }

            return result;
        }

        public static int CountOfA(this string value)
        {
            //if (default == value)
            //if (null == value)
            if (string.IsNullOrWhiteSpace(value))
            //if (null != value && string.Empty != value)
            {
                return -1;
            }

            return value.Count(c => c == 'a');
        }
    }
}
