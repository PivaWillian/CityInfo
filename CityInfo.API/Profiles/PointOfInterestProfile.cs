using AutoMapper;
using CityInfo.API.Models;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile: Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, PointsOfInterestDto>();
            CreateMap<PointsOfInterestForCreationDto, Entities.PointOfInterest>();
            CreateMap<PointOfInterestForUpdateDto, Entities.PointOfInterest>();
            CreateMap<Entities.PointOfInterest, PointOfInterestForUpdateDto>();
        }
    }
}
