using MADAM_Boutique.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MADAM_Boutique.Models.ViewModels;
using MADAM_Boutique.Infrastructure;

namespace MADAM_Boutique.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public int PageSize = 4;
        private  Cart _service;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ViewResult Index(string category, int ProductPage = 1)
            => View(new ProductsListViewModel
            {
                Products = _productRepository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((ProductPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = ProductPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    _productRepository.Products.Count() :
                    _productRepository.Products.Where(e => e.Category == category).Count()
                }
            });

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

        [HttpPost]
        public IActionResult Delete(long productID)
        {
            _service = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            _service.RemoveLine(productID);
            return RedirectToAction("Index");
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