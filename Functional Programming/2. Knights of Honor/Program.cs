using System;

namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> a = array =>
            {
                foreach (var item in array)
                {
                    Console.WriteLine("Sir "+item);
                }
            };
            a(str);
        }
    }
}
