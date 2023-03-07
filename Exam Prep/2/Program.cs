
int n = int.Parse(Console.ReadLine());
string[,] arr = new string[n, n];

string carName = Console.ReadLine();
List<int> tunnelX=new List<int>();
List<int> tunnelY=new List<int>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = input[j];
        if (input[j]=="T")
        {
            tunnelX.Add(i);
            tunnelY.Add(j);
        }
    }
}

int curX = 0;
int curY = 0;

int distance = 0;

string cmds;
while ((cmds=Console.ReadLine())!="End")
{
    switch (cmds)
    {
        case "down":
            curY +=1;
            break;
        case "right":
            curX += 1;
            break;
        case "left":
            curX -= 1;
            break;
        case "up":
            curY -= 1;
            break;
        default:
            break;
    }

    switch (arr[curY, curX])
    {
        case "T": 
                tunnelX.Remove(curY);
                tunnelY.Remove(curX);
            arr[curY, curX] = ".";
            distance += 30;

            curY = tunnelX[0];
            curX = tunnelY[0];
            arr[curY, curX] = ".";
            break;
        case "F":
            distance += 10;
            Console.WriteLine($"Racing car {carName} finished the stage!");
            Console.WriteLine($"Distance covered {distance} km.");
            arr[curY, curX] = "C";
            PrintArray(arr);
            return;
        default:
            distance += 10;
            break;
    }

}
arr[curY, curX] = "C";
Console.WriteLine($"Racing car {carName} DNF.");
Console.WriteLine($"Distance covered {distance} km.");
PrintArray(arr);
static void PrintArray(string[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]);
        }
        Console.WriteLine();
    }
}