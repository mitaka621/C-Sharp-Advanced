Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

Queue<int> greyTiles= new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

Dictionary<string, int>locations= new Dictionary<string, int>() { {"Sink",0 },
{"Oven",0 },
{"Countertop",0 },
{"Wall",0 },
{"Floor",0 }};

while (whiteTiles.Count>0&& greyTiles.Count>0)
{
    int white = whiteTiles.Pop();
    int grey = greyTiles.Dequeue();
    if (white == grey)
    {
        switch (white + grey)
        {
            case 40:
                locations["Sink"]++;
                break;
            case 50:
                locations["Oven"]++;
                break;
            case 60:
                locations["Countertop"]++;
                break;
            case 70:
                locations["Wall"]++;
                break;
            default:
                locations["Floor"]++;
                break;
        }
    }
    else
    {
        whiteTiles.Push(white/2);
        greyTiles.Enqueue(grey);
    }

}

if (!whiteTiles.Any())
{
    Console.WriteLine("White tiles left: none");
}
else
{
    Console.WriteLine("White tiles left: "+String.Join(", ",whiteTiles));
}

if (!greyTiles.Any())
{
    Console.WriteLine("Grey tiles left: none");
}
else
{
    Console.WriteLine("Grey tiles left: " + String.Join(", ", greyTiles));
}

locations = locations.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).Where(x=>x.Value!=0).ToDictionary(x => x.Key, y => y.Value);


foreach (var item in locations)
{
    Console.WriteLine(item.Key+": "+item.Value);
}