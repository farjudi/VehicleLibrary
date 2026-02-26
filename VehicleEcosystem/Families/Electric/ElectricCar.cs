using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;
using VehicleEcosystem.Base;

namespace VehicleEcosystem.Families.Electric
{
    public class ElectricCar : BaseVehicle, ICar
    {
        public ElectricCar(string plate)
             : base( capacity: 5, weight: 1800,plate)
        {
        }
        
        public override string DisplayInfo()
        {
            return $"Electric Car | Plate: {PlateNumber} | Capacity: {Capacity} | Weight: {Weight}kg";
        }
    }
}
