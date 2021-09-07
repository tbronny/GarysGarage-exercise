using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; } = 100.00;

        public double CurrentChargePercentage { get; set; } 

        public void ChargeBattery()
        {
            CurrentChargePercentage = BatteryKWh;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {Name} blazes by you. MMMMMMMMMMM");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The car turned {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The car came to a screeching stop");
        }

        
    }
}
