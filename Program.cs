using System;

namespace dotnet_console_example
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("You must provide the name value as the first argument.");
                Environment.Exit(1);
            }

            string name = args[0];

            Console.WriteLine("Hello {0}", name);
        }
    }
}
