using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClothesWebNET.Models;

namespace ClothesWebNET.Services
{
    public class CartService
    {
        public int CalculateTotal(Cart cart)
        {
            if (cart == null) return 0;
            return cart.TotalMoney();
        }

        public int CountItems(Cart cart)
        {
            if (cart == null) return 0;
            return cart.CartCount();
        }
    }
}
