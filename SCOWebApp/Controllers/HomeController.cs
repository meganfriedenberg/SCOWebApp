using Microsoft.AspNetCore.Mvc;
using SCOWebApp.Models;
using SCOWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITripRepository _tripRepository;

        public HomeController(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository; //constructor injection
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel //get from the model all of the weekly trips
            {
                TripsOfTheWeek = _tripRepository.TripsOfTheWeek
            };

            return View(homeViewModel); //pass off to the view to display
        }
    }
}
