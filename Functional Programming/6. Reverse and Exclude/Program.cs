using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int num = int.Parse(Console.ReadLine());

            input=input.Where(x => x % num != 0).Reverse().ToList();
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
