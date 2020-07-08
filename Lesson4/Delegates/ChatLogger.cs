using System;

namespace Delegates
{
    public class ChatLogger
    {
        public delegate void PreOutHandler(string[] users);
        public delegate string ConvertName(string name);
        public delegate void PostOutHandler(string[] users);

        private PreOutHandler preOutHandler;
        private PostOutHandler postOutHandler;

        public ChatLogger()
        {
        }


        public void SubscribeOnPreOut(PreOutHandler handler)
        //public void SubscribeOnPreOut(Action<string[]> handler)
        {
            preOutHandler += handler;
        }

        public void SubscribeOnPostOut(PostOutHandler handler)
        //public void SubscribeOnPostOut(Action<string[]> handler)
        {
            postOutHandler += handler;
        }

        //public void Out(string[] users, ConvertName converter)
        public void Out(string[] users, Func<string, string> converter)
        {
            if (default != preOutHandler)
            {
                preOutHandler(users);
            }

            foreach (var user in users)
            {
                var nick = converter(user);

                Console.WriteLine(nick);
            }

            if (default != postOutHandler)
            {
                postOutHandler(users);
            }
        }
    }
}
