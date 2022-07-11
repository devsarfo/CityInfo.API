using CityInfo.API.Stores;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[ApiController]
[Route("api/cities/{cityid}/pointsofinterest")]
public class PointsOfInterestController : ControllerBase
{
    [HttpGet]
    public IActionResult GetPointsOfInterest(int cityId)
    {
        var city = CitiesStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
        if (city == null)
        {
            return NotFound();
        }
        return Ok(city.PointsOfInterest);
    }
    
    [HttpGet("{pointsofinterestid}")]
    public IActionResult GetPointsOfInterest(int cityId, int pointsofinterestid)
    {
        var city = CitiesStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
        if (city == null)
        {
            return NotFound();
        }
        
        var pointsOfInterest = city.PointsOfInterest.FirstOrDefault(p => p.Id == pointsofinterestid);
        if (pointsOfInterest == null)
        {
            return NotFound();
        }
        
        return Ok(pointsOfInterest);
    }
}