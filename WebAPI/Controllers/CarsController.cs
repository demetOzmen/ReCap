﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/controller")]
[ApiController]

public class CarsController : ControllerBase
{
    ICarService _carService;

    public CarsController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet("getall")]
    public IActionResult Get()
    {
        var result = _carService.GetAll();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
    [HttpGet("getbyid")]
    public IActionResult Get(int id)
    {
        var result = _carService.GetById(id);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
    [HttpPost("add")]
    public IActionResult Post(Car car)
    {
        var result = _carService.Add(car);
        if (result.Success)
        {
            return Ok();
        }
        return BadRequest(result);
    }
}
 