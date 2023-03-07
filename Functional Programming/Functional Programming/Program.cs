using System;

namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action a = () => Console.WriteLine(string.Join("\n",str));
            a();
        }
    }
}
