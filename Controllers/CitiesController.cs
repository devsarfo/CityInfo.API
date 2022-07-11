using CityInfo.API.Models;
using CityInfo.API.Stores;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[ApiController]
[Route("api/cities")]
public class CitiesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCities()
    {
        var cities = CitiesStore.Current.Cities;
        return Ok(cities);
    }

    [HttpGet("{id}")]
    public IActionResult GetCity(int id)
    {
        var city = CitiesStore.Current.Cities.FirstOrDefault(c => c.Id == id);
        if (city == null)
        {
            return NotFound();
        }
        return Ok(city);
    }
}