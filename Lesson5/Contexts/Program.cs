using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Contexts
{
    class Program
    {
        //static async Task Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    await DownloadAsync();
        //}

        static void Main(string[] args)
        {
            SynchronizationContext.SetSynchronizationContext(new MyContext());

            //var task = SavePage("habrahabr", "http://habrahabr.ru");
            var tasks = new[] {
                DownloadAsync(1),
                DownloadAsync(2),
                DownloadAsync(3),
                DownloadAsync(4),
                DownloadAsync(5)
            };

            Task.WaitAll(tasks);

            Console.ReadKey();
        }

        public static async Task DownloadAsync(int number)
        {
            //await AsyncHelper.RedirectToThreadPool();

            Console.WriteLine($"Start {number}");

            var client = new WebClient();
            await client.DownloadStringTaskAsync("https://google.com");

            Console.WriteLine($"Complete {number}");
        }

        static async Task SavePage(string file, string a)
        {
            using (var stream = File.AppendText(file))
            {
                var html = await new WebClient().DownloadStringTaskAsync(a);
                await stream.WriteAsync(html);
            }
        }
    }

    class MyContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object state)
        {
            Console.WriteLine("MyContext.Post");
            base.Post(d, state);
        }

        public override void Send(SendOrPostCallback d, object state)
        {
            Console.WriteLine("MyContext.Send");
            base.Send(d, state);
        }
    }

    static class AsyncHelper
    {
        public static ThreadPoolRedirector RedirectToThreadPool() => new ThreadPoolRedirector();
    }

    public struct ThreadPoolRedirector : INotifyCompletion
    {
        // awaiter и awaitable в одном флаконе
        public ThreadPoolRedirector GetAwaiter() => this;

        // true означает выполнять продолжение немедленно 
        public bool IsCompleted => Thread.CurrentThread.IsThreadPoolThread;

        public void OnCompleted(Action continuation) =>
            ThreadPool.QueueUserWorkItem(o => continuation());

        public void GetResult() { }
    }
}
