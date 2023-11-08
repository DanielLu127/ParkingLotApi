﻿using Microsoft.AspNetCore.Mvc;
using ParkingLotApi.Dtos;
using ParkingLotApi.Services;
using ParkingLotApi.Exceptions;

namespace ParkingLotApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ParkingLotsController : ControllerBase
{
    private readonly ParkingLotsService _parkingLotsService;

    public ParkingLotsController(ParkingLotsService parkingLotsService)
    {
        _parkingLotsService = parkingLotsService;
    }

    [HttpPost]
    public async Task<ActionResult<ParkingLotsDto>> AddNewParkingLotAsync([FromBody] ParkingLotsDto parkingLotDto)
    {
        return StatusCode(StatusCodes.Status201Created, await _parkingLotsService.AddParkingLotAsync(parkingLotDto));
    }
}
