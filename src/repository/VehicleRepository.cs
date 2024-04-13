using vehicleAPI.Domain;
using vehicleAPI.Infra;

namespace vehicleAPI.Repository;

public interface IVehicleRepository
{
    Task AddVehicle(Vehicle vehicle);
    Task<Vehicle> GetVehicle(int id);
    Task<IEnumerable<Vehicle>> GetVehicles();
}

public class VehicleRepository : IVehicleRepository
{
    private readonly VehicleDbContext _context;
    public VehicleRepository(VehicleDbContext context)
    {
        _context = context;
    }

    public async Task AddVehicle(Vehicle vehicle)
    {
        await _context.AddAsync(vehicle);
        await _context.SaveChangesAsync();
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