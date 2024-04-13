using Microsoft.EntityFrameworkCore;
using vehicleAPI.Domain;
using vehicleAPI.Infra;

namespace vehicleAPI.Repository;

public interface IVehicleRepository
{
    Task AddVehicle(Vehicle vehicle);
    Task<Vehicle> GetVehicle(int id);
    Task<IEnumerable<Vehicle>> GetVehicles(int page, int pageSize);
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

    public async Task<IEnumerable<Vehicle>> GetVehicles(int page = 1, int pageSize = 10)
    {
        return await _context.Vehicles
            .OrderBy(v => v.BrandId)
                .ThenBy(v => v.Name)
                .ThenByDescending(v => v.Year)
            .Skip((page-1)*pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}