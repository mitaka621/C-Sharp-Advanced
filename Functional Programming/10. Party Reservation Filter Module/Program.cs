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

            List<string> filters = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] cmds = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (cmds[0] == "Add filter")
                {
                    filters.Add(input);

                }
                else
                {
                    filters.RemoveAt(filters.FindIndex(x => x.Contains(cmds[1] + ";" + cmds[2])));
                }
                
            }

            foreach (var item in filters)
            {
                string[] cmd = item.Split(";", StringSplitOptions.RemoveEmptyEntries);
                names.RemoveAll(GetPredicat(cmd[1], cmd[2]));
            }
            Console.WriteLine(string.Join(" ", names));
           

            static Predicate<string> GetPredicat(string comand, string str)
            {
                switch (comand)
                {
                    case "Starts with":
                        return x => x.StartsWith(str);
                    case "Ends with":
                        return y => y.EndsWith(str);
                    case "Length":
                        return z => z.Length == int.Parse(str);
                    case "Contains":
                        return t=>t.Contains(str);
                    default:
                        return null;

                }
            }
        }
    }
}
