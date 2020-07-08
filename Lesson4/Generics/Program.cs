using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(default(int));
            //Console.WriteLine(default(byte));
            //Console.WriteLine(default(double));
            //Console.WriteLine(default(bool));
            //Console.WriteLine(default(NewInt));

            //var list = new OldList();
            //Console.WriteLine(list.First());

            //list.Add(4);
            //Console.WriteLine(list.First());

            ////list.Add("test");
            //var value = list.First();
            //var number = (int)value;

            //var stringList = new OldListString();
            //stringList.Add("test");
            //var stringValue = stringList.First();



            ////var newList = new NewList<int, string, double>();
            //var newList = new NewList<int>();
            //newList.Add(4);
            //number = newList.First();

            //var newStringList = new NewList<string>();
            //newStringList.Add("test");

            //Console.ReadKey();


            var t = new NewInt();
            Console.WriteLine(t.Value);
            Console.WriteLine(t.Name);
        }
    }

    public struct NewInt
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
