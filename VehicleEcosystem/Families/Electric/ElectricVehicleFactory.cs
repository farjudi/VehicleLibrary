using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;

namespace VehicleEcosystem.Families.Electric
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar(string plate) => new ElectricCar(plate);


        public IMotorcycle CreateMotorcycle(string plate) => new ElectricMotorcycle(plate);
       
        public IVan CreateVan(string plate)=>new ElectricVan(plate);
       
    }
}
