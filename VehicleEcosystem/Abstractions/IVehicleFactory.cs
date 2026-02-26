using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEcosystem.Abstractions
{
    public interface IVehicleFactory
    {
        ICar CreateCar(string plate);
        IVan CreateVan(string plate);
        IMotorcycle CreateMotorcycle(string plate);
    }
}
//پلاک رو از بیرون میگریم ولی مشخصات اصلی خودرو  در داخل خودش تعیین میکنیم 