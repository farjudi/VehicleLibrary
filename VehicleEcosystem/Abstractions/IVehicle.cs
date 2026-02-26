using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehicleEcosystem.Abstractions
{
    public interface IVehicle
    {
     
        int Capacity { get; }
        double Weight { get; }

        string PlateNumber { get; }

        string DisplayInfo();



    }
}
