using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chessBoard = new char[8, 8];

            int whiteRow =0;
            int whiteCol = 0;
            int blackRow = 0;
            int blackCol = 0;
            for (int i = 0; i < 8; i++)
            {

                string a = Console.ReadLine();
                for (int j = 0; j < 8; j++)
                {
                    chessBoard[i, j] = a[j];
                    if (a[j]=='w')
                    {
                        whiteRow = i;
                        whiteCol = j;
                    }
                    if (a[j] == 'b')
                    {
                        blackRow = i;
                        blackCol = j;
                    }
                }
            }
            int turn = 0;
            while (whiteRow>=0&&blackRow<8)
            {
                if (turn % 2 == 0)
                {
                    //if (whiteCol - 1 >= 0 && whiteCol + 1 < 8)
                        if ((blackCol == whiteCol - 1 || blackCol == whiteCol + 1) && whiteRow - 1 == blackRow)
                        {
                            Console.WriteLine("Game over! White capture on {}.");
                            return;
                        }
                        else
                            whiteRow--;
                }
                else
                {
                    //if (blackCol - 1 >= 0 && blackCol + 1 < 8)
                        if ((blackCol-1 == whiteCol || blackCol+1 == whiteCol) && blackRow + 1 == whiteRow)
                        {
                            Console.WriteLine("Game over! Black capture on {}.");
                            return;
                        }
                        else
                            blackRow++;
                }
                turn++;
            }
            string output=string.Empty;
            
            if (whiteRow==-1)
            {
                switch (whiteRow)
                {
                    case -1: output += 8;
                        break;
                    case 0:
                        output += 7;
                        break;
                    case 1:
                        output += 6;
                        break;
                    case 2:
                        output += 5;
                        break;
                    case 3:
                        output += 4;
                        break;
                    case 4:
                        output += 3;
                        break;
                    case 5:
                        output += 2;
                        break;
                    case 6:
                        output += 2;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Game over! White pawn is promoted to a queen at b8");
            }
            else
                Console.WriteLine("Game over! Black pawn is promoted to a queen at b8");
        }
    }
}
