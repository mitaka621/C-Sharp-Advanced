using System;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(input[0]);

            int cols = int.Parse(input[1]);

            char[,] array = new char[rows, cols];

            string str=Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (counter == str.Length )
                        counter = 0;
                    array[i, j] = str[counter];
                    counter++;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (i%2==0)
              
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j]);
                }
                else
                    for (int j = cols-1; j >=0; j--)
                    {
                        Console.Write(array[i, j]);
                    }
                Console.WriteLine();
            }
        }
    }
}
