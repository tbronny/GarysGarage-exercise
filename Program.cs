using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Tesla modelS = new Tesla() {Name = "modelS", MainColor = "Rose Gold", CurrentChargePercentage = 30.27};
            Cessna mx410 = new Cessna() {Name = "mx410", MainColor = "Yellow"};
            Ram rm1500 = new Ram() {Name = "rm1500", MainColor = "Black"};
            Zero fxs = new Zero() {Name = "fxs", MainColor = "Red", CurrentChargePercentage = 53.25};
            Zero fx = new Zero() {Name = "fx", CurrentChargePercentage = 50.25};

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() 
            {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.Name} has a current charge of {ev.CurrentChargePercentage}%");
            }

            Console.Write("Would you like to charge your vehicles? (Y/N): ");
            var chargeInput = Console.ReadLine();

            if (chargeInput == "Y")
            {
                foreach(IElectricVehicle ev in electricVehicles)
                {
                    // This should charge the vehicle to 100%

                    ev.ChargeBattery();
                }

                foreach(IElectricVehicle ev in electricVehicles)
                {
                    Console.WriteLine($"{ev.Name}: Current charge level: {ev.CurrentChargePercentage}%");
                }

                Console.WriteLine("All Vehicles are fully charged!");
            }

                

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() 
            {
                ram, cessna150
            };

            if (chargeInput == "N" || chargeInput == "Y")
            {
                Console.WriteLine("Gas Vehicles");
                foreach(IGasVehicle gv in gasVehicles)
                {
                    Console.WriteLine($"The {gv.Name} has a fuel percentage of {gv.CurrentTankPercentage}%");
                }

                Console.Write("Would you like to fuel up your vehicles? (Y/N): ");
                var fuelInput = Console.ReadLine();

                if (fuelInput == "Y")

                {
                    foreach(IGasVehicle gv in gasVehicles)
                    {
                        // This should completely refuel the gas tank
                        gv.RefuelTank();
                    }

                    foreach(IGasVehicle gv in gasVehicles)
                    {
                        Console.WriteLine($"{gv.Name}: Current fuel level: {gv.CurrentTankPercentage}");
                    }
                }
            }
            

            // modelS.Drive();
            // modelS.Turn("left");
            // modelS.Stop();
            // Console.WriteLine();
            // mx410.Drive();
            // mx410.Turn("right");
            // mx410.Stop();
            // Console.WriteLine();
            // rm1500.Drive();
            // rm1500.Turn("up");
            // rm1500.Stop();
            // Console.WriteLine();
            // fxs.Drive();
            // fxs.Turn("left");
            // fxs.Stop();
        }
    }
}
