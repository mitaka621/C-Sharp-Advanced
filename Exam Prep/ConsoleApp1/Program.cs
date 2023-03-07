using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        private static object math;

        static void Main(string[] args)
        {
            Queue<double> waterStorage = new Queue<double>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray());

            Stack<double> flourStorage = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray());
            Dictionary<string, int> oven = new Dictionary<string, int>()
            {{"Croissant",0 },
            {"Muffin",0 },
            {"Baguette",0 },
            {"Bagel",0 },};
            while (waterStorage.Any()&& flourStorage.Any())
            {
                double water = waterStorage.Dequeue();
                double flour = flourStorage.Pop();

                double percent1 = (water * 100) / (water + flour);
                double percent2 = 100 - percent1;
                if (percent1 == 50 && percent2 == 50)
                {
                    oven["Croissant"]++;
                }
                else if (percent1 == 40 && percent2 == 60)
                    oven["Muffin"]++;
                else if (percent1 == 30 && percent2 == 70)
                    oven["Baguette"]++;
                else if (percent1 == 20 && percent2 == 80)
                    oven["Bagel"]++;
                else
                {
                    oven["Croissant"]++;
                    
                    flourStorage.Push(Math.Abs(flour-water));
                }
            }
            oven = oven.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Where(x => x.Value != 0).ToDictionary(x => x.Key, y => y.Value);
            foreach (var item in oven)
            {
                Console.WriteLine(item.Key+": "+item.Value);
            }
            if (waterStorage.Any())
            {
                Console.WriteLine("Water left: "+String.Join(", ",waterStorage));
            }
            else
                Console.WriteLine("Water left: None");
            if (flourStorage.Any())
            {
                Console.WriteLine("Flour left: " + String.Join(", ", flourStorage));
            }
            else
                Console.WriteLine("Flour left: None");
        }
    }
}
