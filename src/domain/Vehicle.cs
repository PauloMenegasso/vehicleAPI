using System.ComponentModel.DataAnnotations;

namespace vehicleAPI.Domain;

public class Vehicle
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Year { get; set; }
    public decimal Value { get; set; }
    public string? ImageURL { get; set; }
    public int BrandId { get; set; }
}
