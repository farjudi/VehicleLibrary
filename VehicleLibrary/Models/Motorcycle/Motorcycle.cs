using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Entity;
using VehicleLibrary.Factory;

namespace VehicleLibrary.Models.Motorcycle;

public class Motorcycle : BaseVehicle
{
    public Motorcycle(int capacity, double weight, string plateNumber) : base(capacity, weight, plateNumber) { }


    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle | Capacity: {Capacity} | Weight: {Weight} | Plate: {PlateNumber}");
    }
}
