using System;
using System.Linq;
using System.Text.RegularExpressions;
using PokemonTrainer;

string input;
List<Trainer> trainers= new List<Trainer>();
while ((input=Console.ReadLine())!= "Tournament")
{
    string[] cmds = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (!trainers.Exists(x => x.Name == cmds[0]))
    {
        trainers.Add(new Trainer(cmds[0]));
    }
         trainers.First(x => x.Name == cmds[0]).Collection.Add(new Pokemon(cmds[1], cmds[2], int.Parse(cmds[3])));    
    
}

input = null;
while ((input=Console.ReadLine())!="End")
{
    string cmd = input;
    foreach (var item in trainers)
    {
        if (item.Collection.Any(x => x.Element == cmd))
        {
            item.NumBadges++;
        }
        else
        {
            reset:
            foreach (var item2 in item.Collection)
            {
                item2.Health -= 10;
                if (item2.Health <= 0)
                {
                    item.Collection.Remove(item.Collection.First(x => x.Name == item2.Name));
                    goto reset;
                }
            }
        }
    }
}

trainers = trainers.OrderByDescending(x => x.NumBadges).ToList();

foreach (var item in trainers)
{
    Console.WriteLine($"{item.Name} {item.NumBadges} {item.Collection.Count}");
}