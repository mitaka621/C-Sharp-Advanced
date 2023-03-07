using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] cmds = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmds[0] == "Remove")
                {
                    names.RemoveAll(GetPredicat(cmds[1], cmds[2]));
                }
                else
                {
                    List<string> temp = names.FindAll(GetPredicat(cmds[1], cmds[2])).ToList();
                    foreach (var item in temp)
                    {
                        names.Insert(names.IndexOf(item), item);
                    }
                }
            }

            if (names.Any())
            {
                Console.WriteLine(string.Join(", ",names)+" are going to the party!");
            }
            else
                Console.WriteLine("Nobody is going to the party!");

            static Predicate<string> GetPredicat(string comand,string str)
            {
                switch (comand)
                {
                    case "StartsWith":
                        return x => x.StartsWith(str);
                    case "EndsWith":
                        return y => y.EndsWith(str);
                    case "Length":
                        return z => z.Length == int.Parse(str);
                    default:
                        return null;
                        
                }
            }
        }
    }
}
