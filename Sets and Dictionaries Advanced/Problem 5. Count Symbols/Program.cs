using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> a = new SortedDictionary<char, int>();


            string n = (Console.ReadLine());
            for (int i = 0; i < n.Length; i++)
            {

               
                if (!a.ContainsKey(n[i]))
                {
                    a.Add(n[i], 0);
                }

                a[n[i]]++;
            }

            foreach (var item in a)
            {
                Console.WriteLine(item.Key+": "+item.Value+" time/s");
            }
        }
    }
}
