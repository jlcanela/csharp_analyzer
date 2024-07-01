public class AutoPolicy : Policy
{
    public List<Vehicle> InsuredVehicles { get; set; }
}

public class Vehicle
{
    public int VehicleId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string VIN { get; set; }
}

public class HomePolicy : Policy
{
    public string PropertyAddress { get; set; }
    public decimal PropertyValue { get; set; }
}
