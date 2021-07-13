using System;
using System.Collections.Generic;

namespace Exceptions
{
    public class ConsoleWriter
    {
        public static void WriteVehicleUnitsToConsole(List<VehicleUnit> vehicleUnits)
        {
            for (int i = 0; i < vehicleUnits.Count; i++)
            {
                Console.WriteLine(vehicleUnits[i]);
            }
        }
    }
}
