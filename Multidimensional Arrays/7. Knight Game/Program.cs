using System;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[N, N];

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    chessBoard[i,j] = input[j];
                }
            }

            int maxCollision = -1;
            int currentCollisions = 0;
            int col = 0, row = 0;
            int removeCount = 0;

            while (true)
            {
               
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        currentCollisions = 0;
                        if (chessBoard[i, j] == 'K')
                        {
                            //nagore
                            if (i - 2 >= 0)
                            {
                                if (j + 1 < N)
                                {
                                    if (chessBoard[i - 2, j + 1] == 'K')
                                        currentCollisions++;
                                }

                                if (j - 1 >= 0)
                                {
                                    if (chessBoard[i - 2, j - 1] == 'K')
                                        currentCollisions++;
                                }
                            }
                            if (i - 1 >= 0)
                            {
                                if (j + 2 < N)
                                {
                                    if (chessBoard[i - 1, j + 2] == 'K')
                                        currentCollisions++;
                                }

                                if (j - 2 >= 0)
                                {
                                    if (chessBoard[i - 1, j - 2] == 'K')
                                        currentCollisions++;
                                }
                            }
                            //nadolu
                            if (i + 2 <N)
                            {
                                if (j + 1 < N)
                                {
                                    if (chessBoard[i + 2, j + 1] == 'K')
                                        currentCollisions++;
                                }

                                if (j - 1 >= 0)
                                {
                                    if (chessBoard[i + 2, j - 1] == 'K')
                                        currentCollisions++;
                                }
                            }
                            if (i + 1 <N)
                            {
                                if (j + 2 < N)
                                {
                                    if (chessBoard[i + 1, j + 2] == 'K')
                                        currentCollisions++;
                                }

                                if (j - 2 >= 0)
                                {
                                    if (chessBoard[i + 1, j - 2] == 'K')
                                        currentCollisions++;
                                }
                            }
                        }
                        if (currentCollisions > maxCollision)
                        {
                            maxCollision = currentCollisions;
                            row = i;
                            col = j;
                        }
                        
                    }
                    
                }
                if (maxCollision > 0)
                {
                    chessBoard[row, col] = '0';
                    maxCollision = -1;
                    removeCount++;
                }
                else break;
            }


            Console.WriteLine(removeCount);

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        Console.Write(chessBoard[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
