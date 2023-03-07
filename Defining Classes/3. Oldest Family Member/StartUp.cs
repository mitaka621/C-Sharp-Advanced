using System;
using DefiningClasses;
using System.Linq;
            int n = int.Parse(Console.ReadLine());
            Family fam = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] cmds = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                 
                
                fam.AddMember(new Person(cmds[0], int.Parse(cmds[1])));

            }
            Person oldestPerson = fam.GetOldestMember();
            Console.WriteLine(oldestPerson.Name+" "+ oldestPerson.Age);
