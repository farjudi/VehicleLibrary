using System.ComponentModel.DataAnnotations;
using VehicleLibrary.Enum;
using VehicleLibrary.Factory;

class program
{
    static void Main()
    {
        IVehicleFactory factory = new VehicleFactory();
        var car = factory.Create(VehicleType.Car, 5, 1500, "366 25");
        var van = factory.Create(VehicleType.Van, 2, 4000, "165-789");
        var motorcycle = factory.Create(VehicleType.Motorcycle, 1, 300, "MT59416");
        var truck = factory.Create(VehicleType.Truck, 2, 300, "56489_DOB");

        truck.DisplayInfo();
        van.DisplayInfo();
        motorcycle.DisplayInfo();

    }
}