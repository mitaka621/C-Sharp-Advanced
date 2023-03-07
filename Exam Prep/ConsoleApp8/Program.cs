using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals=new Queue<string>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));

            Stack<int> daylyCal = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int consumedMealsCount = 0;
            int temp = 0;
            while (meals.Any()&& daylyCal.Any())
            {
                string meal = meals.Peek();
                int cal = daylyCal.Pop();
                int mealCal = 0;
                if (temp == 0)
                    switch (meal)
                    {
                        case "salad":
                            mealCal = 350 - temp;
                            break;
                        case "soup":
                            mealCal = 490 - temp;
                            break;
                        case "pasta":
                            mealCal = 680 - temp;
                            break;
                        case "steak":
                            mealCal = 790 - temp;
                            break;
                    }
                else
                    mealCal = temp;
                if (cal - mealCal >= 0)
                {
                    consumedMealsCount++;
                    daylyCal.Push(cal - mealCal);
                    meals.Dequeue();
                    temp = 0;
                }
                else
                {
                    if (!daylyCal.Any())
                    {
                        meals.Dequeue();
                        consumedMealsCount++;
                    }
                    temp = mealCal - cal;
                }

            }
            if (!meals.Any())
            {
                Console.WriteLine($"John had {consumedMealsCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", daylyCal)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {consumedMealsCount} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
