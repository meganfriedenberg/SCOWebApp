using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; } //where is it in the cart?

        public Trip Trip { get; set; }

        public int Amount { get; set; } //the amount of that trip you have added

        public string ShoppingCartID { get; set; } //string for cookie sake
    }
}
