using VehicleLibrary.Factory;
using VehicleLibrary.Enum;
using VehicleLibrary.Models.Car;
using Xunit;

public class VehicleFactoryTests
{
    [Fact]
    public void Create_ShouldReturnCar_WhenTypeIsCar()
    {
        // Arrange
        var factory = new VehicleFactory();

        // Act
        var vehicle = factory.Create(VehicleType.Car, 5, 1500, "A123");

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsType<Car>(vehicle);
    }
}