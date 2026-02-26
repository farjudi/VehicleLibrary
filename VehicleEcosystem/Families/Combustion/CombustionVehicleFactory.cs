using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;

namespace VehicleEcosystem.Families.Combustion
{
    public class CombustionVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar(string plate)=> new CombustionCar(plate);

        public IMotorcycle CreateMotorcycle(string plate)=>new CombustionMotorcycle(plate);
       

        public IVan CreateVan(string plate)=>new CombustionVan(plate);
        
    }
}
