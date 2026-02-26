using VehicleLibrary.Models.Car;

public class VehicleFactoryTestsVan
{
    [Fact]
    public void Constructor_ShouldThrow_WhenCapacityIsNegative()
    {
        Assert.Throws<ArgumentException>(() =>
            new Car(-1, 1500, "A123")
        );
    }
}