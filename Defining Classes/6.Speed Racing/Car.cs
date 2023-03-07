using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelDistance;
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelDistance = 0.0;
        }

        public string Model { get=>model;  }
        public double FuelAmount { get=>fuelAmount;  }
        public double FuelConsumptionPerKilometer { get=>fuelConsumptionPerKilometer;  }
        public double TravelledDistance { get=>travelDistance; }

        private bool CanMove(double distance)
        {
            double fuel = distance* fuelConsumptionPerKilometer;
            if (fuelAmount-fuel>=0)
            return true;
            return false;
        }

        public void Drive(double amount)
        {
            if (CanMove(amount))
            {
                travelDistance += amount;
                fuelAmount -= amount * FuelConsumptionPerKilometer;
            }
            else
            Console.WriteLine("Insufficient fuel for the drive");
        }

        public override string ToString()
        {
            return $"{model} {fuelAmount:F2} {travelDistance}";
        }

    }
}
