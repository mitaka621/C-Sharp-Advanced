using Tuple;
using System;



string[] items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Tuple.CustomTuple<string, string> adress = new Tuple.CustomTuple<string, string>(items[0] + " " + items[1], items[2]);


items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Tuple.CustomTuple<string, int> beer = new(items[0], int.Parse(items[1]));

items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Tuple.CustomTuple<int, double> doub = new(int.Parse(items[0]), double.Parse(items[1]));

Console.WriteLine(adress);
Console.WriteLine(beer);
Console.WriteLine(doub);
