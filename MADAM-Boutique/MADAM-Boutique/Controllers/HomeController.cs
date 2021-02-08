using MADAM_Boutique.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MADAM_Boutique.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

     
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ViewResult Index()
        {
            ViewBag.Title = "This is text View.Bag title in HomeController";
            return View(_productRepository.Products);
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult _AboutUs()
        {
            return View();
        }

        public IActionResult _ContactUs()
        {
            return View();
        }

        public IActionResult Login_Register()
        {
            return View();
        }

      

        public IActionResult _Product()
        {
            return View();
        }
        public IActionResult _Checkout()
        {
            return View();
        }





        public IActionResult _ProductDetail(Product product)
        {
            var test = _productRepository.Products.Where(p => p.ProductID == product.ProductID).FirstOrDefault();
            return View(test);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
