using System;

namespace dotnet_console_example
{
    /// <summary>
    /// Program to get user name from command line and display a Hello {name}
    /// </summary>
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

            Program program = new Program();

            program.Run(name);

           
        }

        /// <summary>
        /// Display Hello {name}
        /// </summary>
        /// <param name="name">User name</param>
        void Run(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
