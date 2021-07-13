using System;

namespace Exceptions
{
    [Serializable]
    public class Truck : VehicleUnit
    {
        public int MaxCargoWeight { get; set; }

        public Truck() { }

        public Truck(int maxCargoWeight, Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
            MaxCargoWeight = maxCargoWeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMaxWeight: {MaxCargoWeight} \n";
        }
    }
}
