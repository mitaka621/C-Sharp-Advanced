using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[,] arr=new string[n,n];
            string[] input;
            Stack<string> sticks = new Stack<string>();
            int row = 0;
            int col = 0;
            int sticksCount = 0;
            for (int i = 0; i < n; i++)
            {
                input= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                    if (input[j] == "B")
                    {
                        row = i;
                        col = j;
                        input[j] = "-";
                    }
                    else
                    if (input[j] != "-" && input[j] != "F")
                        sticksCount++;
                    arr[i,j]=input[j];
                    
                }
            }
            string cmds;
            while ((cmds=Console.ReadLine())!="end"&&sticksCount!=sticks.Count)
            {
                switch (cmds)
                {
                    case "up":
                        row--;
                        if (row < 0)
                        {
                            row = 0;
                            if (sticks.Any())
                            {
                                sticks.Pop();
                                sticksCount--;
                            }
                        }
                        break;
                    case "right":
                        col++;
                        if (col >= n)
                        {
                            col = n - 1;
                            if(sticks.Any())
                            {
                                sticks.Pop();
                                sticksCount--;
                            }
                        }
                        break;
                    case "down":
                        row++;
                        if (row >= n)
                        {
                            row = n - 1;
                            if (sticks.Any())
                            {
                                sticks.Pop();
                                sticksCount--;
                            }
                        }
                        break;
                    case "left":
                        col--;
                        if (col<0)
                        {
                            col = 0;
                            if (sticks.Any())
                            {
                                sticks.Pop();
                                sticksCount--;
                            }
                        }
                        break;
                    default:
                        break;
                }

                switch (arr[row,col])
                {
                    case "F":
                        arr[row,col] = "-";
                        switch (cmds)
                        {
                            case "up":
                                if (row - 1 < 0)
                                {
                                    row = n - 1;
                                }
                                else
                                    row = 0;
                                break;
                            case "right":
                                if (col + 1 >= n)
                                {
                                    col = 0;
                                }
                                else
                                    col = n - 1;
                                break;
                            case "down":
                                if (row+1 >= n)
                                {
                                    row = 0;
                                }
                                else
                                    row=n - 1;
                                break;
                            case "left":
                                if (col - 1 < 0)
                                {
                                    col = n - 1;
                                }
                                else
                                    col = 0;
                                break;
                        }
                        break;
                    case "-":
                        int pozdravleniq = 69;
                        break;
                    default:
                        sticks.Push(arr[row, col]);
                        arr[row,col] = "-";
                        break;
                }
            }

            if (sticksCount == sticks.Count)
            {
                Console.WriteLine($"The Beaver successfully collect {sticksCount} wood branches: "+String.Join(", ",sticks.Reverse())+".");
            }
            else
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {sticksCount-sticks.Count} branches left.");

            arr[row, col] = "B";
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
