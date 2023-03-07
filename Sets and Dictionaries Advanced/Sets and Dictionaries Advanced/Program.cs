using System;
using System.Collections.Generic;
namespace Sets_and_Dictionaries_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames=new HashSet<string>();


            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
