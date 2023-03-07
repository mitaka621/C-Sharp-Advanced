using System;
using System.Collections.Generic;
using System.Linq;
namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            Func<string, int, bool> match = (word, num) => word.Sum(ch => ch) >= num;
            
            List<string> names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<int, List<string>, Func<string, int, bool>, string> returnName =
                (num, names, match) => names.FirstOrDefault(name => match(name, num));

            Console.WriteLine(returnName(N,names,match));

            
        }
    }
}
