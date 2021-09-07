using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; } = 100.00;

        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = BatteryKWh;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {Name} zips by you. Zaaaaaaaap");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The car turned {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The car quickly stops in its tracks");
        }
    }
}
