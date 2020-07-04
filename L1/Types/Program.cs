using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 123;

            int b = 3;
            byte c = 4;

            b = c;

            var t = 3.00;

            var d = true;
            var e = false;

            d = 3 != 0;
            d = c != 0;

            Console.WriteLine(d);

            var test = "Hello SSYP'20";
            Console.WriteLine(test);

            Console.ReadKey();
        }
    }
}
