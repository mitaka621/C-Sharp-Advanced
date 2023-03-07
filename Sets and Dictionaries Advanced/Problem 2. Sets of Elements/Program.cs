using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> m = new HashSet<int>();
            HashSet<int> n = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                m.Add( int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < input[1]; i++)
            {
                n.Add(int.Parse(Console.ReadLine()));
            }
         
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

            foreach (var item in m)
            {
                foreach (var item2 in n)
                {
                    if (item==item2)
                    {
                        Console.Write(item+" ");
                    }
                }
            }
        }
    }
}
