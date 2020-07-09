using System;
using System.Net;
using System.Threading.Tasks;

namespace DownloadPage
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new WebClient();
            //var bytes = client.DownloadString("https://google.com");
            await client.DownloadStringTaskAsync("https://google.com");
            var tasks = new[] {
                DownloadAsync(),
                DownloadAsync(),
                DownloadAsync(),
                DownloadAsync()
            };

            //task.Wait();
            //Console.WriteLine(task.Result);

            //Thread.Sleep(1000);
            Task.WaitAll(tasks);
            //Task.WaitAny(tasks);
        }

        //public static async void DownloadAsync()
        //public static async Task DownloadAsync()
        //public static async ValueTask<> DownloadAsync()
        public static async Task<string> DownloadAsync()
        {
            var client = new WebClient();
            //var raw = await client.DownloadStringTaskAsync("https://google.com");
            var tasks = new[] {
                client.DownloadStringTaskAsync("https://google.com"),
                //client.DownloadStringTaskAsync("https://google.com"),
                //client.DownloadStringTaskAsync("https://google.com"),
                //client.DownloadStringTaskAsync("https://google.com")
            };

            await Task.WhenAll(tasks);
            //await Task.WhenAny(tasks);

            Console.WriteLine("Take task");
            //Console.WriteLine(raw.Length);

            await Task.Delay(1000);
            await Task.Run(() =>
            {
                var raw = client.DownloadString("https://google.com");
            });
            await Task.Run(async () =>
            {
                var raw = await client.DownloadStringTaskAsync("https://google.com");
            });

            //return raw;
            return "Test";
        }

        public static Task<string> DownloadFakeAsync()
        {
            Console.WriteLine("Take task");
            Console.WriteLine("Take task");
            Console.WriteLine("Take task");

            return Task.FromResult("fake");
        }

        public static string Download()
        {
            var client = new WebClient();
            var raw = client.DownloadString("https://google.com");

            Console.WriteLine(raw.Length);

            return raw;
        }
    }
}
