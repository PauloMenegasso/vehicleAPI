namespace vehicleAPI.Infra; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using vehicleAPI.Domain;

public class VehicleDbContext : DbContext
{
    private readonly DBConfig _dbConfig;
    public VehicleDbContext(IOptions<DBConfig> dbSettings)
    {
        _dbConfig = dbSettings.Value;
    }

    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql($"Server={_dbConfig.Server};User Id={_dbConfig.UserId};Password={_dbConfig.Password};Database={_dbConfig.Database}", new MySqlServerVersion(new Version(8, 0, 25)));
    }
}

