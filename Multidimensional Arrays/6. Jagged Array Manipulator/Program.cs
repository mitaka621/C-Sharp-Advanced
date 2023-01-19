using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            decimal[][] jagedArr = new decimal[N][];

            for (int i = 0; i < N; i++)
            {
                jagedArr[i] = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            }
            bool equLengts=false;
            for (int i = 0; i < N-1; i++)
            {
                if (jagedArr[i].Length == jagedArr[i + 1].Length)
                
                    equLengts = true;

                for (int j = 0; j < jagedArr[i].Length; j++)
                {
                    if (equLengts)
                    {
                        jagedArr[i][j] *= 2;
                    }
                    else
                        jagedArr[i][j] /= (decimal)2.0;
                }

                for (int j = 0; j < jagedArr[i+1].Length; j++)
                {
                    if (equLengts)
                    {
                        jagedArr[i+1][j] *= 2;
                    }
                    else
                        jagedArr[i+1][j] /= (decimal)2;
                }
                equLengts=false;
            }
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] cmdArgs = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(cmdArgs[1]);
                int colum = int.Parse(cmdArgs[2]);
                if (row < 0 || row >= N || colum < 0 || colum >= jagedArr[row].Length)
                {

                }
                else
                {
                    decimal value = decimal.Parse(cmdArgs[3]);
                    switch (cmdArgs[0])
                    {
                        case "Add":
                            jagedArr[row][colum] += value;
                            break;
                        case "Subtract":
                            jagedArr[row][colum] -= value;
                            break;
                        default:
                            break;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(String.Join(" ", jagedArr[i]));
            }
        }
    }
}
