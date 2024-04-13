namespace vehicleAPI.Domain
{
    public class VehicleEntryRequest
    {
        public string? Name { get; set; }
        public int Year { get; set; }
        public decimal Value { get; set; }
        public string? ImageURL { get; set; }
        public Brand Brand { get; set; }
    }
}
