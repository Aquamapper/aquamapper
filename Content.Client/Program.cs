using Content.Client.Example;
using Content.Shared.Greeting;

namespace Content.Client
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Content.Client starting");
            Console.WriteLine(SharedGreeting.Text);
            Console.WriteLine(new ClientExample().GetMessage());
        }
    }
}
