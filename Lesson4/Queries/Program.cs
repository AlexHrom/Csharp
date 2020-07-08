using Delegates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new[] {
                "Andrew",
                "Dalas",
                "Kapatich",
                "D'rtanyan",
            };

            var counter = 0;
            //var filtered = new List<string>();
            //foreach (var user in users)
            //{
            //    if (user.Contains("t"))
            //    {
            //        counter++;
            //        filtered.Add(user);
            //    }
            //}


            //var filtered = users.Where(u =>
            //{
            //    counter++;
            //    return u.Contains("t");
            //});
            //.ToList()
            //.ToArray();

            var filtered = from user in users
                           where user.Contains("t")
                           select user;

            ///filtered

            foreach (var user in filtered)
            {
                Console.WriteLine($"{counter} {user}");
            }

            foreach (var user in filtered)
            {
                Console.WriteLine($"{counter} {user}");
            }


            var numbers = new[] { "1", "2", "3" };
            var parsed = numbers.Select<string, int>(s => int.Parse(s));

            parsed.OrderBy(n => n);

            var entities = new List<Entity>();
            entities.OrderBy(e => e.UpdatedAt);
            entities.OrderByDescending(e => e.UpdatedAt);

            parsed.Max();
            entities.Max(e => e.UpdatedAt);

            parsed.Min();
            entities.Min(e => e.UpdatedAt);

            entities.Count();
            entities.Count(e => e.Name.Contains("t"));

            entities.Any();
            entities.Any(e => e.Name.Contains("t"));

            //entities.All();
            entities.All(e => e.Name.Contains("t"));

            entities.First();
            entities.FirstOrDefault();
            entities.First(e => e.Name.Contains("t"));
            entities.FirstOrDefault(e => e.Name.Contains("t"));

            entities.Last();
            entities.LastOrDefault();
            entities.Last(e => e.Name.Contains("t"));
            entities.LastOrDefault(e => e.Name.Contains("t"));

            entities.Single();
            entities.SingleOrDefault();
            entities.Single(e => e.Name.Contains("t"));
            entities.SingleOrDefault(e => e.Name.Contains("t"));
        }
    }
}
