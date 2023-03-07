using System;
using System.Collections.Generic;
using System.Linq;
namespace _5._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, List<int>, List<int>> brain = (cmd, list) =>
            {
                List<int> output = new List<int>();
                switch (cmd)
                {
                    case "add":
                        foreach (var item in list)
                        {                           
                            output.Add(item+1);
                        }
                        break;
                    case "multiply":
                        foreach (var item in list)
                        {
                            output.Add(item * 2);
                        }
                        break;
                    case "subtract":
                        foreach (var item in list)
                        {
                            output.Add(item - 1);
                        }
                        break;
                    case "print":
                        Console.WriteLine(String.Join(" ",list));
                        output = list;
                        break;
                    default:
                        break;
                }
                return output;
            };
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string cmd;
            while ((cmd=Console.ReadLine())!="end")
            {
                input= brain(cmd, input);
            }
            
        }
    }
}
