
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine1)
        {
            Model = model;
            Engine1 = engine1;
            Weight = "n/a";
            Color = "n/a";
        }
        public Car(string model, Engine engine1,int weight):this(model,engine1)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine1, string color):this(model,engine1)
        {
            Color = color;
        }
        public Car(string model, Engine engine1, int weight, string color):this(model,engine1,weight)
        {
            Color = color;
        }
        public string Model { get; set; }
        public Engine Engine1 { get; set; }
        public object Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return String.Format($"{Model}:\n  {Engine1.ToString()}  Weight: {Weight}\n  Color: {Color}");
        }
    }
}
