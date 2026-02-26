using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;
using VehicleEcosystem.Base;

namespace VehicleEcosystem.Families.Combustion
{
    public class CombustionMotorcycle:BaseVehicle,IMotorcycle
    {
        public CombustionMotorcycle(string plate) :base(1,250,plate)
        {
            
        }

        public override string DisplayInfo()
        => $"Combustion Motorcycle | Plate: {PlateNumber}";
    }
}
