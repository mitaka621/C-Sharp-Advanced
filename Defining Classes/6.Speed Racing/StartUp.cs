using System;
using System.Linq;
using SpeedRacing;


int N = int.Parse(Console.ReadLine());

List<Car> cars=new List<Car>();
for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    cars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));

}
string input2;
while ((input2 = Console.ReadLine()) != "End")
{
    string[] cmdArgs = input2.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    cars.FirstOrDefault(x => x.Model == cmdArgs[1]).Drive(double.Parse(cmdArgs[2]));
}

foreach (var item in cars)
{
    Console.WriteLine(item.ToString());
}