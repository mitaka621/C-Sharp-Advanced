using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> a = new Dictionary<int, int>();


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                int input = int.Parse(Console.ReadLine());
                if (!a.ContainsKey(input))
                {
                    a.Add(input, 0);
                }

                a[input]++;
            }

            foreach (var item in a)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
