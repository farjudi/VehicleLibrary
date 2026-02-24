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
    [Fact]
    public void Create_ShouldThrowException_WhenTypeIsInvalid()
    {
        var factory = new VehicleFactory();

        Assert.Throws<ArgumentException>(() =>
            factory.Create((VehicleType)999, 1, 1, "X")
        );
    }

}