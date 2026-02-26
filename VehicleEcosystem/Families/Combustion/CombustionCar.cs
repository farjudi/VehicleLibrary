using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;
using VehicleEcosystem.Base;

namespace VehicleEcosystem.Families.Combustion
{
    public class CombustionCar : BaseVehicle, ICar
    {
        public CombustionCar(string plate) : base(5, 1600, plate)
        {

        }

        public override string DisplayInfo()
       => $"Combustion Car | Plate: {PlateNumber}";

    }
}
