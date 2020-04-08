using System;

namespace Hello
{
    internal static class Program
    {
        private static void Main()
        {
            new BadClass("first").DoSomething(5);
            new BadClass("Second").DoSomethingElse("else", DateTime.Now);
            Console.ReadKey(true);
            Console.WriteLine();

            new GoodClass("first").DoSomething(5);
            new GoodClass("Second").DoSomethingElse("else", DateTime.Now);
            Console.ReadKey(true);
        }
    }
}
