using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;
using VehicleEcosystem.Base;

namespace VehicleEcosystem.Families.Electric
{
    public class ElectricMotorcycle : BaseVehicle, IMotorcycle
    {
        public ElectricMotorcycle(string plate) :base(capacity:2,weight:250 ,plate) {}
        public override string DisplayInfo()
        {
            return $"Electric Motorcycle | Plate: {PlateNumber} | Capacity: {Capacity} | Weight: {Weight}";
            
        }
    }
}
