using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary.Entity;


namespace VehicleLibrary.Factory
{
    public interface IVehicle
    {
     
        int Capacity { get; }
        double Weight { get; }

        string PlateNumber { get; }

        void DisplayInfo();



    }
}
