using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var instance = new Student("Andrew");
            //var cost = instance.GoToEat();
            //Console.WriteLine($"{instance.Name} eat for {cost} rubles.");

            //var human = new Human("Alex");
            //Console.WriteLine(human.Name);

            var a = new Human("Andrew");
            var b = new Human("Bratishka");

            Console.WriteLine(a.FullName);
            Console.WriteLine(b.FullName);

            Human.SchoolName = "SSYP";

            Console.WriteLine(a.FullName);
            Console.WriteLine(b.FullName);
        }
    }

    class Student : Human
    {
        public Student(string name) : base(name)
        {
        }

        public int GoToEat()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Name} eat {i}");
            }

            var random = new Random();
            return random.Next(200);
        }
    }

    public class Human
    {
        public static string SchoolName { get; set; }

        public Human(string name)
        {
            Name = name;
        }

        private protected string Name { get; }

        public string FullName
        {
            get
            {
                return $"{SchoolName} {Name}";
            }
        }
    }
}
