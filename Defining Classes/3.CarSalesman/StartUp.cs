using System;
using System.Linq;
using System.Text.RegularExpressions;
using CarSalesman;


int N = int.Parse(Console.ReadLine());
Regex reg = new Regex(@"\d");
List<Engine> engines = new();
List<Car> cars= new List<Car>();
for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    switch (input.Length)
    {
        case 2:
            engines.Add(new Engine(input[0], int.Parse(input[1])));
            break;
        case 3:
            if (reg.IsMatch(input[2]))
            
                engines.Add(new Engine(input[0], int.Parse(input[1]), int.Parse(input[2])));
            else
                engines.Add(new Engine(input[0], int.Parse(input[1]), input[2]));
            break;
        case 4:
            engines.Add(new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]), input[3]));
            break;
        default:
            break;
    }
}


int M = int.Parse(Console.ReadLine());

for (int i = 0; i < M; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    switch (input.Length)
    {
        case 2:
            cars.Add(new Car(input[0], engines.First(x => x.Model == input[1])));
            break;
        case 3:
            if (reg.IsMatch(input[2]))
                cars.Add(new Car(input[0], engines.First(x => x.Model == input[1]), int.Parse(input[2])));
            else
                cars.Add(new Car(input[0], engines.First(x => x.Model == input[1]), input[2]));
            break;
        case 4:
            cars.Add(new Car(input[0], engines.First(x => x.Model == input[1]), int.Parse(input[2]), input[3]));
            break;
        default:
            break;
    }
}

foreach (var item in cars)
{
    Console.WriteLine(item);
}