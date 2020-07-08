using System;

namespace Delegates
{
    class Program
    {
        //public delegate void WriteToConsole(string name);

        public static void Main(string[] args)
        {
            //WriteToConsole del;

            //del = Write;
            //del("Andrew");

            //Console.WriteLine("Hello World!");

            var users = new[] {
                "Andrew",
                "Dalas",
                "Kapatich",
            };

            var logger = new ChatLogger();

            logger.SubscribeOnPreOut(u =>
            {
                Console.WriteLine($"Will notified {u.Length} users.");
            });
            logger.SubscribeOnPreOut(u =>
            {
                Console.WriteLine($"Second pre out");
            });
            //logger.SubscribeOnPostOut(u =>
            //{
            //    Console.WriteLine($"Was notified {u.Length} users.");
            //});

            //logger.Out(users, DotaConvert);
            //logger.Out(users, PUBGConvert);
            //logger.Out(users, u => $"<SSYP> {u}");
            logger.Out(users, (u) =>
            {
                return $"<SSYP> {u}";
            });


            var entity = new Entity()
            {
                Name = "Andrew",
                UpdatedAt = DateTimeOffset.MinValue
            };
            var updater = new Updater();
            updater.Apply(entity, update =>
            {
                update.Name = "Super Andrew";
            });
        }

        private static string DotaConvert(string name)
        {
            return $"<DOTA2> {name}";
        }

        private static string PUBGConvert(string name)
        {
            return $"<PUBG> {name}";
        }

        //public static void Write(string name)
        //{
        //    Console.WriteLine($"Test 1 {name}");
        //}


    }
}
