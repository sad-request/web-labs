using System;
using System.Linq;

namespace remove_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1 || args.Length < 1)
            {
                Console.WriteLine("Incorrect number of arguments!\nUsage remove_duplicates.exe <input string>");
                Console.ReadKey(true);
                Environment.Exit(1);
            }
            else
            {
            	args[0] = String.Concat(args[0].Distinct());
            	Console.WriteLine(args[0]);
            	Console.ReadKey(true);
            }
        }
    }
}