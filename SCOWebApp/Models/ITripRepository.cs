using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public interface ITripRepository
    {

        IEnumerable<Trip> AllTrips { get; }

        IEnumerable<Trip> TripsOfTheWeek { get; }

        Trip GetTripById(int tripId);


    }
}
