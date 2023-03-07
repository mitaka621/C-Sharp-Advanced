using ComparingObjects;

string input;

List<Person> perons=new List<Person>();
while ((input=Console.ReadLine())!="END")
{
    string[] cmds = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    perons.Add(new Person() { Name = cmds[0], Age = int.Parse(cmds[1]), Town = cmds[2] });
}


int n = int.Parse(Console.ReadLine())-1;
int matches=0;
int notmatches=0;
foreach (var item in perons)
{
    if (item.CompareTo(perons[n]) == 0)
    {
        matches++;
    }
    else
        notmatches++;
}

if (matches==1)
{
    Console.WriteLine("No matches");
}
else
    Console.WriteLine($"{matches} {notmatches} {perons.Count}");
