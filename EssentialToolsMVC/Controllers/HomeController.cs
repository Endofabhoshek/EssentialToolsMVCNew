using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialToolsMVC.Models;
using Ninject;
namespace EssentialToolsMVC.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products = {
             new Product {Name="Product 1", Category="Category 1", Descritpion="Description 1", Price=13M },
             new Product {Name="Product 2", Category="Category 1", Descritpion="Description 3", Price=152M },
             new Product {Name="Product 3", Category="Category 1", Descritpion="Description 2", Price=2133M },
             new Product {Name="Product 4", Category="Category 2", Descritpion="Description 4", Price=563M },
             new Product {Name="Product 5", Category="Category 2", Descritpion="Description 5", Price=1456M }
        };

        // GET: Home
        public ActionResult Index()
        {
            //IKernel ninjectKernel = new StandardKernel();
            //ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();

            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CartTotal();
            return View(totalValue);
        }
        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
    }
}