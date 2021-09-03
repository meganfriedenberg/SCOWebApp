using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class TripRepository : ITripRepository
    {
        private readonly AppDbContext _appDbContext;

        public TripRepository(AppDbContext appDbContext) //dependency injection since it is registered on the startup class
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Trip> AllTrips
        {
            get
            {
                return _appDbContext.Trips.Include(c => c.Category);
            }
        }

        public IEnumerable<Trip> TripsOfTheWeek
        {
            get
            {
                return _appDbContext.Trips.Include(c => c.Category).Where(t => t.IsTripOfTheWeek);
            }
        }

        public Trip GetTripById(int tripId)
        {
            return _appDbContext.Trips.FirstOrDefault(t => t.TripId == tripId);
        }
    }
}
