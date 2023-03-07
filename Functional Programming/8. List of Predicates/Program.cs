using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Func<int, List<int>> func = x =>
            {
                List<int> list = new List<int>();
                for (int i = 1; i <= num; i++)
                {
                    list.Add(i);
                }
                return list;
            };
            List<int> list = func(num);
            HashSet<int> ints = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

            list = list.Where(x =>
            {

                foreach (var item in ints)
                {
                    if (x % item != 0)
                    {
                        return false;
                    }
                }
                return true;
            }).ToList();
            Console.WriteLine(String.Join(" ",list));

        }
    }
}
