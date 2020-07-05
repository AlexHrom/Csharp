using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var test = "Hello";
            var test2 = @"\n";
            var test21 = "\n";
            var test3 = $"World {test}";

            var t = test;


            test += "123"; //Hello123

            if (test == "Hello123")
            //if (test.Equals("Hello123"))
            {
                Console.WriteLine("OK");
            }

            var builder = new StringBuilder();

            for (var i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    builder.AppendLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    builder.AppendLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    builder.AppendLine("Fizz");
                }
                else
                {
                    //builder.AppendLine($"{i}");
                    builder.AppendLine(i.ToString());
                }
            }

            var o = new object();

            Console.WriteLine(builder);
            Console.WriteLine(builder.ToString());
        }
    }
}
