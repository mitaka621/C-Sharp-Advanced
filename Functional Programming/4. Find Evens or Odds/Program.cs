using System;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> match;
           
            int[] nums=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string cmd = Console.ReadLine();
            if (cmd == "even")
            {
                match = num => num % 2 == 0;
            }
            else
                match=num => num % 2 != 0;
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                if (match(i))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
