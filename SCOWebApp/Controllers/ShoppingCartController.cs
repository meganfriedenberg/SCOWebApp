using Microsoft.AspNetCore.Mvc;
using SCOWebApp.Models;
using SCOWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ITripRepository _tripRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ITripRepository tripRepository, ShoppingCart shoppingCart) //constructor injection
        {
            _tripRepository = tripRepository;
            _shoppingCart = shoppingCart;
        } //allows us to get controller
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int tripId)
        {
            var selectedTrip = _tripRepository.AllTrips.FirstOrDefault(t => t.TripId == tripId);

            if(selectedTrip != null)
            {
                _shoppingCart.AddToCart(selectedTrip, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int tripId)
        {
            var selectedTrip = _tripRepository.AllTrips.FirstOrDefault(t => t.TripId == tripId);

            if(selectedTrip != null)
            {
                _shoppingCart.RemoveFromCart(selectedTrip);
            }
            return RedirectToAction("Index");
        }
    }
}
