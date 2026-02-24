using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Entity;
using VehicleLibrary.Factory;

namespace VehicleLibrary.Models.Car
{

    public class Car : BaseVehicle
    {
        public Car(int capacity, double weight, string plateNumber) : base(capacity, weight, plateNumber) { }
        public override void DisplayInfo()
        {
         

            Console.WriteLine($"Car | Capacity: {Capacity} | Weight: {Weight} | Plate: {PlateNumber}");

        }
    }
}
