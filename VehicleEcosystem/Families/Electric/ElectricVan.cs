using VehicleEcosystem.Abstractions;
using VehicleEcosystem.Base;

public class ElectricVan : BaseVehicle, IVan
{
    public ElectricVan(string plate) : base(capacity: 2, weight: 250, plate) { }
    public override string DisplayInfo()
    {
        return $"Electric Van | Plate: {PlateNumber}| Capacity: {{Capacity}} | Weight: {{Weight}}kg\"; ";
    }
}