using System;
using System.Linq;
using RawData;


int n = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    cars.Add(new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4], double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]), double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]), int.Parse(input[12])));
}


string zdr = Console.ReadLine();
List<Car>output=new List<Car>();
if (zdr== "fragile")
{
    output = cars.Where(x => x.Cargo1.Type == "fragile").Where(x => x.Tires.Any(x => x.Pressure < 1)).ToList();
}
else
    output = cars.Where(x => x.Cargo1.Type == "flammable").Where(x => x.Engine1.Power>250).ToList();

foreach (var item in output)
{
    Console.WriteLine(item.Model);
}