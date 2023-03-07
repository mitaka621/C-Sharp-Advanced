using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[,] arr = new string[n, n];
            int bCount = 0, sCount = 0, wCount = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = input[j];
                }
            }
            string cmd;
            int boarCount = 0;
            while ((cmd=Console.ReadLine())!= "Stop the hunt")
            {
                string[] cmdArgs = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                switch (cmdArgs[0])
                {
                    case "Collect":
                        switch (arr[row,col])
                        {
                            case "B":
                                bCount++;
                                break;
                            case "S":
                                sCount++;
                                break;
                            case "W":
                                wCount++;
                                break;
                        }
                        arr[row, col] = "-";
                        break;
                    default:
                        string direction = cmdArgs[3];
                        switch (direction)
                        {
                            case "up":
                                for (int i =row ; i >=0; i-=2)
                                {
                                    if (arr[i,col]!="-")
                                    {
                                        boarCount++;
                                        arr[i, col] = "-";
                                    }
                                }
                            break;
                            case "down":
                                for (int i = row; i <n; i += 2)
                                {
                                    if (arr[i, col] != "-")
                                    {
                                        boarCount++;
                                        arr[i, col] = "-";
                                    }
                                }
                                break;
                            case "left":
                                for (int i = col; i >=0; i -= 2)
                                {
                                    if (arr[row,i] != "-")
                                    {
                                        boarCount++;
                                        arr[row, i] = "-";
                                    }
                                }
                                break;
                            case "right":
                                for (int i = col; i <n; i += 2)
                                {
                                    if (arr[row, i] != "-")
                                    {
                                        arr[row, i] = "-";
                                        boarCount++;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine($"Peter manages to harvest {bCount} black, {sCount} summer, and {wCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boarCount} truffles.");
            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < n; j++)
                {
                    if (j+1==n)
                    {
                        Console.Write(arr[i, j]);
                    }
                    else
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
