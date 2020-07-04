using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            var array = Array.Empty<int>();
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            for (var i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            do
            {
                Console.WriteLine("do - while");
            } while (false);

            while (false)
            {
                Console.WriteLine("While");
            }


            for (var iterator = array2.GetEnumerator(); iterator.MoveNext();)
            {
                var item = iterator.Current;
                Console.WriteLine(item);
            }

            int t = 3;
            switch (t)
            {
                case 3:
                    Console.WriteLine("switch - 3");
                    break;

                default:
                    Console.WriteLine("switch - default");
                    break;
            }
        }
    }
}
