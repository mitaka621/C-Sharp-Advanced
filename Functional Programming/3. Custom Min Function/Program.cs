using System;
using System.Linq;

namespace _3._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] set=Console.ReadLine().Split().Select(int.Parse).ToArray();

            Action<int[]> action = arr =>
            {
                int min = int.MaxValue;
                foreach (var item in arr)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                }
                Console.WriteLine(min);
            };

            action(set);

        }
    }
}
