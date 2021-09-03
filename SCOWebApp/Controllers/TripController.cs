using Microsoft.AspNetCore.Mvc;
using SCOWebApp.Models;
using SCOWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Controllers
{
    public class TripController : Controller
    {
        private readonly ITripRepository _tripRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TripController(ITripRepository tripRepository, ICategoryRepository categoryRepository) //dependency injection since registered in startup.cs
        {
            //giving controller access to models
            _tripRepository = tripRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            TripsListViewModel tripsListViewModel = new TripsListViewModel();
            tripsListViewModel.Trips = _tripRepository.AllTrips;

            tripsListViewModel.CurrentCategory = "Camping";
            return View(tripsListViewModel);
        }

        public IActionResult Details(int id) //for page navigation to each trip
        {
            var trip = _tripRepository.GetTripById(id);
            if(trip == null)
            {
                return NotFound(); //404 error
            }
            return View(trip); //returns a view with the corresponding id as a parameter
        }
    }
}
