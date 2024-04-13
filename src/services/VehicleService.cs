using vehicleAPI.Domain;
using vehicleAPI.Repository;

namespace vehicleAPI.Services;

public interface IVehicleService {
    Task<Vehicle> CreateVehicle(VehicleEntryRequest vehicleEntryRequest);
    Task<Vehicle> GetVehicle(int id);
    Task<IEnumerable<Vehicle>> GetVehicles();
}

public class VehicleService : IVehicleService
{
    private readonly IVehicleRepository _vehicleRepository;
    public VehicleService(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    public async Task<Vehicle> CreateVehicle(VehicleEntryRequest vehicleEntryRequest)
    {
        var vehicle = new Vehicle()
        {
            Name = vehicleEntryRequest.Name,
            Year = vehicleEntryRequest.Year,
            Value = vehicleEntryRequest.Value,
            ImageURL = vehicleEntryRequest.ImageURL,
            BrandId = (int)vehicleEntryRequest.Brand
        };

        await _vehicleRepository.AddVehicle(vehicle);
        return vehicle;
    }

    public Task<Vehicle> GetVehicle(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Vehicle>> GetVehicles()
    {
        throw new NotImplementedException();
    }
}