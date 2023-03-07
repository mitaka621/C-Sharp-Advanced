using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < N; i++)
            {

                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe.Add(input[0], new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!wardrobe[input[0]].ContainsKey(item))
                    {
                        wardrobe[input[0]].Add(item, 0);
                    }

                    wardrobe[input[0]][item]++;
                }
               
            }
            string[] cmd = Console.ReadLine().Split();
            foreach (var item in wardrobe)
            {
                Console.WriteLine(item.Key+" clothes:");
                foreach (var item2 in wardrobe[item.Key])
                {
                    Console.Write("* "+ item2.Key+" - "+item2.Value);
                    if (cmd[0] == item.Key && cmd[1]==item2.Key)
                    {
                        Console.WriteLine(" (found!)");
                    }else
                        Console.WriteLine();
                }
            }
        }
    }
}
