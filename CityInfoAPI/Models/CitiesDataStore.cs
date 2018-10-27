using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Models
{
    
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
                    {
                        new CityDto()
                        {
                            Id = 1,
                            Name = "New York City",
                            Description = "The one with the big park.",
                            PointsOfInterest = new List<PointOfInterestDto>()
                            {
                                new PointOfInterestDto() {
                                    Id = 1,
                                    Name = "Central Park",
                                    Description = "The most visited urban park in the United States"
                                },

                                new PointOfInterestDto() {
                                    Id = 2,
                                    Name = "Empire State Building",
                                    Description = "A 102 Story skyscraper located in Midtown"

                                }
                            }
                        }


                    };

            CityDto city2 = new CityDto();
            city2.Id = 2;
            city2.Name = "Antwerp";
            city2.Description = "The one with the cathedral that was never finished";

            Cities.Add(city2);

        }



    }
}
