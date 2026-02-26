using VehicleLibrary.Factory;
using VehicleLibrary.Enum;
using VehicleLibrary.Models.Car;
using Xunit;

public class VehicleFactoryTestsCar
{
    [Fact]
  
    public void Create_ShouldSetPropertiesCorrectly_WhenTypeIsCar()
    {
        var factory = new VehicleFactory();

        var vehicle = factory.Create(VehicleType.Car, 5, 1500, "A123");

        var car = Assert.IsType<Car>(vehicle);

        Assert.Equal(5, car.Capacity);
        Assert.Equal(1500, car.Weight);
        Assert.Equal("A123", car.PlateNumber);
    }

    [Theory]
    [InlineData(0, 1000, "A123")]
    [InlineData(-1, 1000, "A123")]
    public void Create_ShouldThrowException_WhenCapacityIsInvalid(int capacity, double weight, string plate)
    {
        var factory = new VehicleFactory();

        Assert.Throws<ArgumentException>(() =>
            factory.Create(VehicleType.Car, capacity, weight, plate));
    }
    [Fact]
    public void Create_ShouldThrowException_WhenPlateIsNull()
    {
        var factory = new VehicleFactory();

        Assert.Throws<ArgumentException>(() =>
            factory.Create(VehicleType.Car, 4, 1200, null));
    }
}