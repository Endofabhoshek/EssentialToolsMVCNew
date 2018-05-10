using System;
using System.Collections.Generic;
using System.Linq;
using EssentialToolsMVC.Models;

namespace EssentialToolsMVC.Models
{

    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}
