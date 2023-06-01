using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Instance { get;} = new CitiesDataStore(); //singleton

        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Tijucas",
                    Description = "The dinosaur city",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 1,
                            Name = "Tijusaur",
                            Description = "Our little baby"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Praça Church",
                            Description = "Our beautiful church"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "São João",
                    Description = "Something",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 3,
                            Name = "Maybe the Square",
                            Description = "Must be nice"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 4,
                            Name = "Koch",
                            Description = "Big supermarket"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Canelinha",
                    Description = "Small city",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 5,
                            Name = "The mud",
                            Description = "The mud there is nice"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 6,
                            Name = "Cathedral",
                            Description = "Bigger church"
                        }
                    }
                }
            };
        }
    }
}
