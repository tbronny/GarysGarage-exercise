using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        string Name { get; set; }
        double CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
}