using System;

namespace Garage
{
    public class Vehicle
    {
        public string Name { get; set; }

        public string MainColor { get; set; }

        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine(direction);
        }

        public virtual void Stop()
        {
            Console.WriteLine("");
        }

    }
}
