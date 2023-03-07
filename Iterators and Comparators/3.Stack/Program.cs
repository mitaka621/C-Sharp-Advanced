using StackNS;

string input;
StackNS.Stack<int> customStack = new();
while ((input=Console.ReadLine())!="END")
{
    switch (input)
    {
        case "Pop":
            customStack.Pop();
            break;
        default:
            string temp = input.Substring(input.IndexOf(' '));
            customStack.Push(temp.Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            break;
    }
}

foreach (var item in customStack)
{
    Console.WriteLine(item);
}
foreach (var item in customStack)
{
    Console.WriteLine(item);
}