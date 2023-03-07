using GenericBoxofString;


int n = int.Parse(Console.ReadLine());
List<int> strings=new List<int>();
for (int i = 0; i < n; i++)
{
    strings.Add(int.Parse(Console.ReadLine()));
}
int[] temp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Box<int> newBox = new Box<int>();
newBox.Swap(strings, temp[0], temp[1]);

Console.WriteLine(newBox.ToString());
