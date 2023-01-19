using System;
using System.Linq;

namespace Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < N; j++)
                {
                    array[i,j]=temp[j];
                }
            }
            int sum1=0, sum2=0;
            for (int i = 0; i < N; i++)
            {
                sum1 += array[i, i];
            }
            int k = N-1;
            for (int i = 0; i <N; i++)
            {
                
                    sum2+=array[i, k];
                k--;
                
            }
            Console.WriteLine(Math.Abs(sum2 -sum1));
        }
    }
}
