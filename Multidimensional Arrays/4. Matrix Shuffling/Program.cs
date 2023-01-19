using System;
using System.Linq;
namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int N = int.Parse(input[0]);

            int M = int.Parse(input[1]);
            string[,] array = new string[N, M];
            for (int i = 0; i < N; i++)
            {
                string[] temp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < M; j++)
                {
                    array[i, j] = temp[j];
                }
            }
            string cmdArgs;
            while ((cmdArgs=Console.ReadLine())!="END")
            {
                string[] cmd = cmdArgs.Split();
                if (cmd.Length!=5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                switch (cmd[0])
                {
                    case "swap":
                        int x = int.Parse(cmd[1]);
                        int y = int.Parse(cmd[2]);
                        int x2 = int.Parse(cmd[3]);
                        int y2 = int.Parse(cmd[4]);
                        if (x < 0 || x >= N || y < 0 || y > M || x2 < 0 || x2 >= N || y2 < 0 || y > M)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }
                        else
                        {
                            string c = array[x, y];
                            array[x, y] = array[x2, y2];
                            array[x2, y2] = c;

                            for (int i = 0; i < N; i++)
                            {
                                for (int j = 0; j < M; j++)
                                {
                                    Console.Write(array[i,j]+" ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}
