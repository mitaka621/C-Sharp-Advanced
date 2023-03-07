using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffeQuantities = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Stack<int> milkQuantities = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<int, string> reqDrinks = new Dictionary<int, string>()
            {
                {50 ,"Cortado"},
                {75 ,"Espresso"},
                {100 ,"Capuccino"},
                {150 ,"Americano"},
                {200 ,"Latte"}
            };
            Dictionary<string, int> storeDrinks = new Dictionary<string, int>();

            while (coffeQuantities.Any()&&milkQuantities.Any())
            {
                int coffe = coffeQuantities.Dequeue();
                int milk = milkQuantities.Pop();
                if (reqDrinks.Keys.Contains(coffe+milk))
                {
                    if (!storeDrinks.ContainsKey(reqDrinks[coffe + milk]))
                    {
                        storeDrinks.Add(reqDrinks[coffe + milk], 0);
                    }
                    storeDrinks[reqDrinks[coffe + milk]]++;
                }
                else
                    milkQuantities.Push(milk - 5);
            }
            if (!coffeQuantities.Any() && !milkQuantities.Any())
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

            if (!coffeQuantities.Any())
            {
                Console.WriteLine("Coffee left: none");
            }
            else
                Console.WriteLine("Coffee left: "+String.Join(", ",coffeQuantities));

            if (!milkQuantities.Any())
            {
                Console.WriteLine("Milk left: none");
            }
            else
                Console.WriteLine("Milk left: "+ String.Join(", ", milkQuantities));

            storeDrinks = storeDrinks.OrderBy(x => x.Value).ThenByDescending(x => x.Key).ToDictionary(x=>x.Key,y=>y.Value);
            foreach (var item in storeDrinks)
            {
                Console.WriteLine(item.Key+": "+item.Value);
            }
        }
    }
}
