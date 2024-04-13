using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using vehicleAPI.Domain;
using vehicleAPI.Services;

namespace vehicleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase {
    private readonly IVehicleService _vehicleService;
    public VehicleController(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    [HttpGet]
    public IActionResult Get() {
        return Ok("Vehicle Controller");
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] VehicleEntryRequest request) {
        var result = await _vehicleService.CreateVehicle(request);
        if (result.Id == 0) {
            return BadRequest();
        }
        return Ok(result);
    }
}