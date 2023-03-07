using Froggy;

int[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Lake lake = new Lake();
lake.Add(arr);
List<int> list = new List<int>();
foreach (var item in lake)
{
  list.Add(item);
}

Console.WriteLine(string.Join(", ",list));