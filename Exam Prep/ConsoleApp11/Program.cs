using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char[, ] armory = new char[n, n];
            int row = 0, col = 0;
            int coins = 0;
            List<int> mirRow = new List<int>();
            List<int> mirCol = new List<int>();
            for (int i = 0; i < n; i++)
            {

                string a = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    armory[i, j] = a[j];
                    if (a[j]=='A')
                    {
                        row = i;
                        col = j;
                        armory[i, j] = '-';
                    }
                    if (a[j] == 'M')
                    {
                        mirRow.Add(i);
                        mirCol.Add(j);
                    }
                }
            }

            while (coins<=65)
            {

                string input = Console.ReadLine();
                switch (input)
                {
                    case "right":
                        col++;
                        break;
                    case "left":
                        col--;
                        break;
                    case "up":
                        row--;
                        break;
                    case "down":
                        row++;
                        break;
                    default:
                        break;
                }
                if (row < 0 || col < 0 || row >= n || col >= n)
                {
                    break;
                }
                if (char.IsDigit(armory[row, col]))
                {
                    coins += int.Parse(armory[row, col].ToString());
                    armory[row, col] = '-';
                }
                else
                    if (armory[row, col] == 'M')
                {
                    mirRow.Remove(row);
                    mirCol.Remove(col);
                    armory[row, col] = '-';
                    row = mirRow[0];
                    col = mirCol[0];
                    armory[row, col] = '-';
                }
            }
            if (coins >65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                armory[row, col] = 'A';
            }
            else

                Console.WriteLine("I do not need more swords!");

            Console.WriteLine($"The king paid {coins} gold coins.");
            for (int i = 0; i < n; i++)
            {


                for (int j = 0; j < n; j++)
                {
                    Console.Write(armory[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
