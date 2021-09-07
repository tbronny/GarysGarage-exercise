using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; } = 100.00;

        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = FuelCapacity;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {Name} drives past you. BROOOOOOOOOOM");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The car turned {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The car stops abrubtly");
        }
    }
}
