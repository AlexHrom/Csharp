using System;
using System.Net;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                await DownloadAsync();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            Console.ReadKey();
        }

        public static async Task DownloadAsync()
        {
            var client = new WebClient();
            await client.DownloadStringTaskAsync("https://google.com");

            throw new Exception("My exception");
        }
    }
}
