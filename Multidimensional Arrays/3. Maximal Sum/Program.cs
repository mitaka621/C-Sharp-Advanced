using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int N = int.Parse(input[0]);

            int M = int.Parse(input[1]);
            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < M; j++)
                {
                    array[i, j] = temp[j];
                }
            }
            int sum = int.MinValue;
            
            int row=0, col=0;
            for (int i = 0; i < N-2; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < M-2; j++)
                {
                    currentSum = array[i, j] + array[i, j + 1] + array[i,j+2]
                        + array[i+1, j] + array[i+1, j + 1] + array[i+1, j + 2]
                        + array[i+2, j] + array[i+2, j + 1] + array[i+2, j + 2];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        row = i;
                        col = j;
                    }
                }
                
            }
            Console.WriteLine("Sum = "+sum);
            for (int i = row; i < row+3; i++)
            {
                for (int j = col; j < col+3; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
