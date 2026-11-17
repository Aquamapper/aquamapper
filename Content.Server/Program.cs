using Content.Server.Example;
using Content.Shared.Greeting;

namespace Content.Server
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Content.Server starting");
            Console.WriteLine(SharedGreeting.Text);
            Console.WriteLine(new ServerExample().GetMessage());
        }
    }
}
