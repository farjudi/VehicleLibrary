using VehicleLibrary.Enum;
using VehicleLibrary.Factory;
using VehicleLibrary.Models.Car;
using VehicleLibrary.Models.Motorcycle;

public class VehicleFactoryTestsMotorcycle
{
    [Fact]
  
    public void Create_ShouldSetPropertiesCorrectly_WhenTypeIsMotorcycle()
    {
        var factory = new VehicleFactory();

        var vehicle = factory.Create(VehicleType.Motorcycle, 1, 1200, "12348");

        var motorcycle = Assert.IsType<Motorcycle>(vehicle);

        Assert.Equal(1, motorcycle.Capacity);
        Assert.Equal(1200, motorcycle.Weight);
        Assert.Equal("12348", motorcycle.PlateNumber);
    }
    [Fact]
    public void Create_ShouldThrowException_WhenTypeIsInvalid()
    {
        var factory = new VehicleFactory();

        Assert.Throws<ArgumentException>(() =>
            factory.Create((VehicleType)999, 1, 1, "X")
        );
    }

}