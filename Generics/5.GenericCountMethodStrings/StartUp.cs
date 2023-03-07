using GenericBoxofString;


int n = int.Parse(Console.ReadLine());
List<double> strings = new List<double>();
for (int i = 0; i < n; i++)
{
    strings.Add(double.Parse(Console.ReadLine()));
}

double value = double.Parse(Console.ReadLine());

Box<double> box = new();
Console.WriteLine(box.Compare(strings, value)); 