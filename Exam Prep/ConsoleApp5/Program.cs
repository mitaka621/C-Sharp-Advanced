int n = int.Parse(Console.ReadLine());
char[,] battlefield = new char[n, n];
string input;
int row = 0;
int col = 0;

int mineCount = 0;
int cruserCount = 0;
for (int i = 0; i < n; i++)
{
    input=Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        battlefield[i, j] = input[j];
        if (input[j]=='S')
        {
            row = i;
            col = j;

            battlefield[i, j] = '-';
        }
    }
}
while (mineCount<3&&cruserCount<3)
{
    input = Console.ReadLine();
    switch (input)
    {
        case "right":
            col += 1;
            break;
        case "down":
            row++;
            break;
        case "left":
            col--;
            break;
        case "up":
            row--;
            break;
    }

    switch (battlefield[row,col])
    {
        case '*':
            mineCount++;
            battlefield[row, col] = '-';
            break;
        case 'C':
            cruserCount++;
            battlefield[row, col] = '-';
            break;
        default:
            break;
    }
}
if (mineCount==3)
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{row}, {col}]!");
}
else
    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");

battlefield[row, col] = 'S';
for (int i = 0; i < n; i++)
{
   
    for (int j = 0; j < n; j++)
    {
        Console.Write(battlefield[i,j]);
    }
    Console.WriteLine();
}



