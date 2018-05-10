using System;
using System.Collections.Generic;
using System.Linq;
using EssentialToolsMVC.Models;

namespace EssentialToolsMVC.Models
{

    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;

        public LinqValueCalculator(IDiscountHelper discounterParam)
        {
            discounter = discounterParam;
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            //return products.Sum(p => p.Price);
            return discounter.ApplyDiscount(products.Sum(x => (x.Price)));
        }
    }
}
