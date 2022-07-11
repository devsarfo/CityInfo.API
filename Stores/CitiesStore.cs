using CityInfo.API.Models;

namespace CityInfo.API.Stores;

public class CitiesStore
{
    public List<CityDto> Cities { get; set; }

    public static CitiesStore Current { get; } = new CitiesStore();

    public CitiesStore()
    {
        Cities = new List<CityDto>()
        {
            new CityDto
            {
                Id = 1,
                Name = "Grismtad",
                Description = "Grimstad is a kommune in Agder County",
                PointsOfInterest = new List<PointsOfInterestDto>
                {
                    new PointsOfInterestDto
                    {
                        Id = 1,
                        Name = "J. J. Ugland Stadion",
                        Description = "The home grounds of FK Jerv"
                    },
                    new PointsOfInterestDto
                    {
                        Id = 2,
                        Name = "Grimstad Kirke",
                        Description = "The local parish church"
                    }
                }
            },
            new CityDto
            {
                Id = 2,
                Name = "Fevik",
                Description = "Fevik is a town in Grimstad which is a kommune in Agder County",
                PointsOfInterest = new List<PointsOfInterestDto>
                {
                    new PointsOfInterestDto
                    {
                        Id = 1,
                        Name = "Fevik Stadion",
                        Description = "The home grounds of IL Express"
                    },
                    new PointsOfInterestDto
                    {
                        Id = 2,
                        Name = "OSM Stadion",
                        Description = "The home grounds of IL Express 2"
                    },
                    new PointsOfInterestDto
                    {
                        Id = 3,
                        Name = "Fevik Kirke",
                        Description = "The local parish church"
                    }
                }
            },
            new CityDto
            {
                Id = 3,
                Name = "Arendal",
                Description = "Arendal is a kommune in Agder County",
                PointsOfInterest = new List<PointsOfInterestDto>
                {
                    new PointsOfInterestDto
                    {
                        Id = 1,
                        Name = "Arendal Stadion",
                        Description = "The home grounds of IL Express"
                    },
                    new PointsOfInterestDto
                    {
                        Id = 2,
                        Name = "Arendal Kirke",
                        Description = "The local parish church"
                    }
                }
            }
        };
    }
}