using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; } = 100.00;

        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = FuelCapacity;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {Name} drives by you. Zoooooom");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The car turned {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The car came to a stop");
        }
    }
}
