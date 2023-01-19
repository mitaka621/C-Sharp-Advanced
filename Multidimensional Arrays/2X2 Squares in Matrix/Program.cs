using System;
using System.Linq;
namespace _2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);

            int M = int.Parse(input[1]);
            string[,] array = new string[N, M];
            for (int i = 0; i < N; i++)
            {
                string[] temp = Console.ReadLine().Split();
                
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = temp[j];
                }
            }
            int counter = 0;
            for (int i = 0; i < N-1; i++)
            {
                for (int j = 0; j < M-1; j++)
                {
                    if (array[i, j] == array[i,j+1])
                    {
                        if (array[i, j] == array[i+1,j]&& array[i, j]== array[i + 1, j+1])
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
            
        }
    }
}
