using SCOWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.ViewModels
{
    public class TripsListViewModel
    {
        public IEnumerable<Trip> Trips { get; set; }

        public string CurrentCategory { get; set; }
    }
}
