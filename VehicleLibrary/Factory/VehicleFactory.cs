using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Enum;
using VehicleLibrary.Models.Car;
using VehicleLibrary.Models.Motorcycle;
using VehicleLibrary.Models.Van;

namespace VehicleLibrary.Factory
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle Create(VehicleType vehicleType, int capacity, double weight, string plateNumber)
        {
            return vehicleType switch
            {
                VehicleType.Car => new Car(capacity, weight, plateNumber),
                VehicleType.Van => new Van(capacity, weight, plateNumber),
                VehicleType.Motorcycle => new Motorcycle(capacity, weight, plateNumber),
                _ => throw new ArgumentException("Invalid vehicle type")

            };
        }
    }
}
