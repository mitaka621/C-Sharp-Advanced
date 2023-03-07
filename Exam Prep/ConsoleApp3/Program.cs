using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vowels = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Stack<string> consonants = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            string[] words = new string[] { "pear", "flour", "pork", "olive" };
            int[] count = new int[words.Length];
            List<string> list = new List<string>();
            while (consonants.Any())
            {
                string vowel;
                if (vowels.Any())
                {
                    vowel = vowels.Dequeue();
                }
                else vowel = "]";
                string consonant = consonants.Pop();

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains(vowel))
                    {
                        count[i]++;
                    }
                    if (words[i].Contains(consonant))
                    {
                        count[i]++;
                    }
                   
                }

            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= count[i])
                {
                    list.Add(words[i]);
                }
            }
            
            Console.WriteLine("Words found: " + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
