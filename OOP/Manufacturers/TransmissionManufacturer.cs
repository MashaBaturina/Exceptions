using System.Collections.Generic;

namespace Exceptions
{
    public class TransmissionManufacturer
    {
        public TransmissionManufacturer() { }

        public Dictionary<Transmissions, List<Transmission>> GetTransmissions()
        {
            Transmission carTransmission = new("Automatic  gearbox", 6, "Jatco");
            Transmission truckTransmission = new("Mechanical gearbox", 6, "Zahnrad Fabrik");
            Transmission busTransmission = new("Mechanical gearbox", 6, "Zahnrad Fabrik");
            Transmission scooterTransmission = new("Automatic  gearbox", 6, "Jatco");

            List<Transmission> carTransmissions = new() { carTransmission };
            List<Transmission> truckTransmissions = new() { truckTransmission };
            List<Transmission> busTransmissions = new() { busTransmission };
            List<Transmission> scooterTransmissions = new() { scooterTransmission };

            Dictionary<Transmissions, List<Transmission>> transmissions = new()
            {
                { Transmissions.Car, carTransmissions },
                { Transmissions.Truck, truckTransmissions },
                { Transmissions.Bus, busTransmissions },
                { Transmissions.Scooter, scooterTransmissions }
            };

            return transmissions;
        }
    }
}
