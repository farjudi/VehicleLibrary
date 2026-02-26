using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleEcosystem.Abstractions;

namespace VehicleEcosystem
{
    public class FleetBuilder
    {
        private readonly IVehicleFactory _factory;

        public FleetBuilder(IVehicleFactory factory)
        {
            _factory = factory;
        }


        public List<IVehicle> BuildFleet()
        {
            var fleet = new List<IVehicle>
            {
                _factory.CreateCar("125_ش_156"),
                _factory.CreateVan("5611ش"),
                _factory.CreateMotorcycle("1234_78")
            };

            return fleet;

        }
    }



}
