using System;
using System.Collections.Generic;

namespace Problem_3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            SortedSet<string> a = new SortedSet<string>();
            for (int i = 0; i < N; i++)
            {

                string[] input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    a.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ",a));
        }
    }
}
