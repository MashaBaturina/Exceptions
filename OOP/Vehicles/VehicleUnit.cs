using System;
using System.Xml.Serialization;

namespace Exceptions
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Bus))]
    [Serializable]
    public abstract class VehicleUnit
    {
       public Engine Engine { get; set; }
       public Transmission Transmission { get; set; }
       public Chassis Chassis { get; set; }

        public VehicleUnit() { }

        protected VehicleUnit(Engine engine, Transmission transmission, Chassis chassis)
        {
            if (engine == null || transmission == null || chassis == null)
            {
                throw new InitializationException("Vehicle unit can not be created.");
            }

            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;
        }

        public override string ToString()
        {
            return $"Engine: {Engine} \nTransmission: {Transmission} \nChassis: {Chassis}";
        }
    }
}
