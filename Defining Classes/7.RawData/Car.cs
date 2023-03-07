using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public Car(string model, int speed, int power, int weight, string type, double pressure1,int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4)
        {
            Model = model;
            Engine1 = new Engine(speed,power);
            Cargo1 = new Cargo(type, weight);
            Tires = new Tire[4];
            Tires[0] = new Tire(pressure1, age1);
            Tires[1] = new Tire(pressure2, age2);
            Tires[2] = new Tire(pressure3, age3);
            Tires[3] = new Tire(pressure4, age4);
        }

        public string Model { get; set; }

        public Engine Engine1 { get; set; }

        public Cargo Cargo1 { get; set; }

        public Tire[] Tires { get; set; }
    }
}
