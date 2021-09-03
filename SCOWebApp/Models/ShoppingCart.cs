using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string ShoppingCartID { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services) //dependency injection
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session; //gets the current sesssion

            var context = services.GetService<AppDbContext>();

            string cartID = session.GetString("CartID") ?? Guid.NewGuid().ToString(); //check if there already is a session

            session.SetString("CartID", cartID);

            return new ShoppingCart(context) { ShoppingCartID = cartID }; //ensures a shoppingcart is returned upon request
        }

        public void AddToCart(Trip trip, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Trip.TripId == trip.TripId && s.ShoppingCartID == ShoppingCartID);

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartID = ShoppingCartID,
                    Trip = trip,
                    Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Trip trip)
        {
            var shoppingCartItem =
                _appDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Trip.TripId == trip.TripId && s.ShoppingCartID == ShoppingCartID);
            var localAmt = 0;

            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1) //remove one there's more than one
                {
                    shoppingCartItem.Amount--;
                    localAmt = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem); //there's only one of it but we want it removed
                }
            }

            _appDbContext.SaveChanges();

            return localAmt;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                (ShoppingCartItems =
                _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartID)
                    .Include(s => s.Trip)
                    .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartID == ShoppingCartID);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems); //removes the total number of items

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartID)
                .Select(c => c.Trip.Price * c.Amount).Sum(); //linq query
            return total;
        }
    }

}
