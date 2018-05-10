using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EssentialToolsMVC.Models;

namespace EssentialToolsMVC.Models
{
    public class ShoppingCart
    {
        
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CartTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}