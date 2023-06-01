using CityInfo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities/{cityId}/poinstofinterest")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointsOfInterestDto>> GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Instance.Cities.FirstOrDefault(c => c.Id == cityId);

            if(city == null)
            {
                return NotFound();
            }
            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{pointOfInterestId}", Name = "GetPointOfInterest")]
        public ActionResult<PointsOfInterestDto> GetPointOfInterest(int cityId, int pointOfInterestId) 
        {
            var city = CitiesDataStore.Instance.Cities.FirstOrDefault(c => c.Id == cityId);
            if( city == null )
            {
                return NotFound();
            }

            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(c => c.Id == pointOfInterestId);
            if( pointOfInterest == null)
            {
                return NotFound();
            }
            return Ok(pointOfInterest);
        }

        [HttpPost]
        public ActionResult<PointsOfInterestDto> CreatePointOfInterest(
            int cityId,
            PointsOfInterestForCreationDto pointOfInterest)
        {
            var city = CitiesDataStore.Instance.Cities.FirstOrDefault(c => c.Id == cityId);
            if(city == null)
            {
                return NotFound();
            }

            var maxPointOfInterestId = CitiesDataStore.Instance.Cities.SelectMany(c => c.PointsOfInterest)
                .Max(p => p.Id);

            var finalPointOfInterest = new PointsOfInterestDto()
            {
                Id = ++maxPointOfInterestId,
                Name = pointOfInterest.Name,
                Description = pointOfInterest.Description
            };

            city.PointsOfInterest.Add(finalPointOfInterest);

            return CreatedAtRoute("GetPointOfInterest",
                new
                {
                    cityId = cityId,
                    pointOfInterestId = finalPointOfInterest.Id
                },
                finalPointOfInterest);
        }
    }
}
