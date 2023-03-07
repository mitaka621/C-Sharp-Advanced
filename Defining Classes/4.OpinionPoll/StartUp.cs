using System;
using DefiningClasses;
using System.Linq;

List<Person> people = new List<Person>();

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] a = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    people.Add(new Person(a[0], int.Parse(a[1])));
}

List<Person> OlderThan30=people.Where(p => p.Age > 30).OrderBy(n=>n.Name).ToList();

foreach (var item in OlderThan30)
{
    Console.WriteLine(item.ToString());
}