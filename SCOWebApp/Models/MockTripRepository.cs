using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class MockTripRepository : ITripRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Trip> AllTrips =>
            new List<Trip>
            {
                new Trip{TripId = 1, Name="Little Lakes", Price=75.60M, ShortDescription="Easy backpacking", LongDescription="insertLong", Category=_categoryRepository.AllCategories.ToList()[1], ImageURL="https", IsTripOfTheWeek=false, ImageThumbnailUrl="https://uscband.usc.edu/wp-content/uploads/2021/08/littlelakesValley.jpg"},
                new Trip{TripId = 2, Name="Santa Moncia surfing", Price=25.60M, ShortDescription="Easy surfing", LongDescription="insertLong", Category=_categoryRepository.AllCategories.ToList()[2], ImageURL="https", IsTripOfTheWeek=false, ImageThumbnailUrl="https"},
                new Trip{TripId = 3, Name="Sandstone Camping", Price=35.60M, ShortDescription="Medium camping", LongDescription="insertLong", Category=_categoryRepository.AllCategories.ToList()[0], ImageURL="https", IsTripOfTheWeek=false, ImageThumbnailUrl="https"},
                new Trip{TripId = 4, Name="Sequoia backpacking", Price=175.60M, ShortDescription="Hard hiking", LongDescription="insertLong", Category=_categoryRepository.AllCategories.ToList()[1], ImageURL="https", IsTripOfTheWeek=false, ImageThumbnailUrl="https://uscband.usc.edu/wp-content/uploads/2021/08/sequoiakings.jpg"}
            };

        public IEnumerable<Trip> TripsOfTheWeek { get; }

        public Trip GetTripById(int tripId)
        {
            return AllTrips.FirstOrDefault(t => t.TripId == tripId);
        }
    }
}
