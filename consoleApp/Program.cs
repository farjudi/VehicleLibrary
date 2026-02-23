using System.ComponentModel.DataAnnotations;
using VehicleLibrary.Enum;
using VehicleLibrary.Factory;

class program
{
    static void Main()
    {
        IVehicleFactory factory = new VehicleFactory();
        var car = factory.Create(VehicleType.Car, 5, 1500, "366 25");
        var van = factory.Create(VehicleType.Van, 2, 4000, "TRK-789");
        var motorcycle = factory.Create(VehicleType.Motorcycle, 1, 300, "MTR-456");

        car.DisplayInfo();
        van.DisplayInfo();
        motorcycle.DisplayInfo();

    }
}