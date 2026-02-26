using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;
using VehicleEcosystem.Base;

namespace VehicleEcosystem.Families.Combustion
{
    public class CombustionVan : BaseVehicle, IVan

    {
        public CombustionVan(string plate) :base(12,2000, plate)
        {
            
        }
        public override string DisplayInfo()
         => $"Combustion Van | Plate: {PlateNumber}";
    }
}
