using MADAM_Boutique.Models;
using Microsoft.AspNetCore.Mvc;
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

        public HomeController(IProductRepository product)
        {
            _productRepository = product;
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

        public IActionResult _ProductDetail()
        {
            return View();
        }

        public IActionResult _Product()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
