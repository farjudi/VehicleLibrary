using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Entity;

namespace VehicleLibrary.Models.truck
{
    public class Truck : BaseVehicle
    {
        public Truck(int capacity, double weight, string plateNumber) : base(capacity, weight, plateNumber) { }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck | Capacity: {Capacity} | Weight: {Weight} | Plate: {PlateNumber}");
        }
    }
}
