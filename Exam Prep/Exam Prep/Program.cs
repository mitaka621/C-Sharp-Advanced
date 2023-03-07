Stack<int> seq1 = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

Queue<int> seq2 = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

int coff = 0;

while (seq1.Count>0&&seq2.Count>0)
{
    int temp1 = seq1.Pop();
    int temp2=seq2.Dequeue();
    if (temp1 * temp2+coff <= 300)
    {
        coff += temp1 * temp2;
    }
    else
    {
        seq2.Enqueue(temp2);
        coff -= 30;
        if (coff<0)
        {
            coff = 0;
        }
    }
}
if (seq2.Any())
{
    Console.WriteLine($"Drinks left: {string.Join(", ",seq2)}");
}
else
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");

Console.WriteLine($"Stamat is going to sleep with {coff} mg caffeine.");