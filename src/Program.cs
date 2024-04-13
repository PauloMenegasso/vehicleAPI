using vehicleAPI.Domain;
using vehicleAPI.Infra;
using vehicleAPI.Repository;
using vehicleAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<DBConfig>(builder.Configuration.GetSection("DBConfig"));
builder.Services.AddDbContext<VehicleDbContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IVehicleService, VehicleService>();

builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();
