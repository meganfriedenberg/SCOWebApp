using SCOWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Trip> TripsOfTheWeek { get; set; }
    }
}
