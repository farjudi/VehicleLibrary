using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Enum;

namespace VehicleLibrary.Factory
{
    public interface IVehicleFactory
    {
        IVehicle Create(VehicleType vehicleType,
                               int capacity, 
                               double weight,
                               string plateNumber);
       
        
    }
}
