using System;
using System.Collections.Generic;
using System.Linq;

namespace Exceptions
{
    public class Autopark
    {
        public List<VehicleUnit> AutoparkVehicleUnits { get; private set; }

        public Autopark(List<VehicleUnit> vehicleUnits)
        {
            AutoparkVehicleUnits = vehicleUnits;
        }

        public void AddVehicle(VehicleUnit newVehicleUnit)
        {
            try
            {
                if (newVehicleUnit == null)
                {
                    throw new AddException("Vehicle unit can not be added.");
                }

                AutoparkVehicleUnits.Add(newVehicleUnit);
            }
            catch (AddException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<VehicleUnit> GetAutoByParameter(string parameter, string value)
        {
            List<VehicleUnit> vehicleUnits = new();

            try
            {
                vehicleUnits = parameter switch
                {
                    "Engine serial number" => AutoparkVehicleUnits.Where(x => x.Engine.SerialNumber == value).ToList(),
                    _ => throw new GetAutoByParameterException("The parameter is incorrect."),
                };
            }
            catch (GetAutoByParameterException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return vehicleUnits;
        }

        public void UpdateAuto(string engineSerialNumber, VehicleUnit newVehicleUnit)
        {
            try
            {
                bool isVehicleUnitContained = AutoparkVehicleUnits.Any(x => x.Engine.SerialNumber == engineSerialNumber);

                if (!isVehicleUnitContained)
                {
                    throw new UpdateAutoException($"Vehicle with engine serial number {engineSerialNumber} is not found and can not be updated.");
                }

                var selectedVehicleUnitIndex = AutoparkVehicleUnits.FindIndex(x => x.Engine.SerialNumber == engineSerialNumber);
                AutoparkVehicleUnits[selectedVehicleUnitIndex] = newVehicleUnit;
            }
            catch (UpdateAutoException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveAuto(string engineSerialNumber)
        {
            try
            {
                bool isVehicleUnitContained = AutoparkVehicleUnits.Any(x => x.Engine.SerialNumber == engineSerialNumber);

                if (!isVehicleUnitContained)
                {
                    throw new RemoveAutoException($"Vehicle with engine serial number { engineSerialNumber } is not found and can not be deleted.");
                }

                var selectedVehicleUnitIndex = AutoparkVehicleUnits.FindIndex(x => x.Engine.SerialNumber == engineSerialNumber);
                AutoparkVehicleUnits.RemoveAt(selectedVehicleUnitIndex);
            }
            catch (RemoveAutoException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
