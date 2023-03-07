using Threeuple;
using System;



string[] items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Threeuple<string, string,string> adress = new (items[0] + " " + items[1], items[2], items[3]);


items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Threeuple<string, int,bool> beer = new(items[0], int.Parse(items[1]), items[2]=="drunk");

items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Threeuple<string, double,string> doub = new(items[0], double.Parse(items[1]), items[2]);

Console.WriteLine(adress);
Console.WriteLine(beer);
Console.WriteLine(doub);
