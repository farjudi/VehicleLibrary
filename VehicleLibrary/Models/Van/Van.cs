using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Entity;
using VehicleLibrary.Factory;

namespace VehicleLibrary.Models.Van
{
    public class Van : BaseVehicle
    {
        public Van(int capacity, double weight, string plateNumber) : base(capacity, weight, plateNumber)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Van | Capacity: {Capacity} | Weight: {Weight} | Plate: {PlateNumber}");

        }
    }
}
