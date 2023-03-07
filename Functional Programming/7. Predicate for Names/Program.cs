using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            names=names.Where(x=>x.Length<=a).ToList();
            Console.WriteLine(String.Join("\n",names));
        }
    }
}
