using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Factory;

namespace VehicleLibrary.Entity
{
    public abstract class BaseVehicle : IVehicle
    {
        public int Capacity { get; protected set; }

        public double Weight { get; protected set; }

        public string PlateNumber { get; protected set; }
        protected BaseVehicle(int capacity, double weight, string plateNumber)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero");

            if (weight <= 0)
                throw new ArgumentException("Weight must be greater than zero");

            if (string.IsNullOrWhiteSpace(plateNumber))
                throw new ArgumentException("PlateNumber is required");



            Capacity = capacity;
            Weight = weight;
            PlateNumber = plateNumber;
        }
        public abstract void DisplayInfo();
    }
}
