using System.IO;
using System.Linq;

namespace Helps
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Первое решение 
            //var data = File.ReadAllText("./input.txt");
            //var splitted = data.Split(' ');
            //var numbers = new int[splitted.Length];
            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    if (int.TryParse(splitted[i], out var value))
            //    {
            //        numbers[i] = value;
            //    }
            //    else
            //    {
            //        throw new Exception("Bad data");
            //    }

            //    numbers[i] = int.Parse(splitted[i]);
            //}

            //var sum = 0;
            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}

            //File.WriteAllText("./output.txt", $"{sum}");
            //File.WriteAllText("./output.txt", string.Format("{0}", sum));
            //File.WriteAllText("./output.txt", sum.ToString());

            //Второе решение 
            var sum2 = File.ReadAllText("./input.txt")
                           .Split(' ')
                           .Select(n => int.Parse(n))
                           .Sum();

            File.WriteAllText("./output.txt", $"{sum2}");
        }
    }
}
