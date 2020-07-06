using Methods;
using System;
using System.Collections.Generic;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var human = new Human("Andrew");
            human.

            var list = new List<int>
            {
                2,3,4,5
            };
            var array = new[] { 1, 2, 3, 4 };

            foreach (var item in list)
            {

            }

            foreach (var item in array)
            {

            }


            var instance = new Student("Andrew");
            Console.WriteLine(instance.Name);
            instance.Name = "123";
            //instance = new Student();

            //Console.WriteLine(instance.PublicName);
            //instance.PublicName = "1232 ";
            //Console.WriteLine(instance.PublicName);

            //instance.PropertyName = "123";
            //Console.WriteLine(instance.PropertyName);


            //Console.WriteLine(Student.SchoolName);
            //Console.WriteLine(Student.Name);
        }
    }

    class Student
    {
        //private string name;

        public Student()
        {
            var t = 4;
        }

        public Student(string name)
        {
            Name = name;
        }

        public string Name { get; }

        //public string PropertyName { get; set; }

        //private string name2;
        //public string PropertyName2
        //{
        //    get
        //    {
        //        return name2;
        //    }
        //    set
        //    {
        //        name2 = value;
        //    }
        //}

        public string PublicName
        {
            get
            {
                //Name = "123";

                return $"MR {Name}";
            }
            //set
            //{
            //    name = value.Trim();
            //}
        }
    }
}
