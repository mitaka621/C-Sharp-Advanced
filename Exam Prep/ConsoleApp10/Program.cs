using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steels=new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Stack<int> carbons=new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Dictionary<int, string>swords=new Dictionary<int, string>()
           
            {
                { 70,"Gladius"},
                { 80,"Shamshir"},
                { 90,"Katana"},
                { 110,"Sabre"},
                { 150,"Broadsword"},

            };

            Dictionary<string, int> ProducedSwords = new Dictionary<string, int>();
            while (steels.Any()&&carbons.Any())
            {
                int steel = steels.Dequeue();
                int carbon = carbons.Pop();
                if (swords.ContainsKey(steel + carbon))
                {
                    if (!ProducedSwords.ContainsKey(swords[steel + carbon]))
                    {
                        ProducedSwords.Add(swords[steel + carbon], 0);
                    }
                    ProducedSwords[swords[steel + carbon]]++;
                }
                else
                    carbons.Push(5+carbon);

            }
            if (ProducedSwords.Any())
            {
                Console.WriteLine($"You have forged {ProducedSwords.Values.Sum()} swords.");
            }
            else
            Console.WriteLine("You did not have enough resources to forge a sword.");

            if (steels.Any())
            {
                Console.WriteLine("Steel left: " + String.Join(", ", steels));
            }
            else
                Console.WriteLine("Steel left: none");

            if (carbons.Any())
            {
                Console.WriteLine("Carbon left: " + String.Join(", ", carbons));
            }
            else
                Console.WriteLine("Carbon left: none");

            ProducedSwords = ProducedSwords.OrderBy(x => x.Key).ToDictionary(x=>x.Key,y=>y.Value);
            foreach (var item in ProducedSwords)
            {
                Console.WriteLine(item.Key+": "+item.Value);
            }
        }
    }
}
