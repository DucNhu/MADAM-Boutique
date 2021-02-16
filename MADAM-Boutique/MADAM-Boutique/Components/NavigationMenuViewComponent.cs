using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADAM_Boutique.Models;
namespace MADAM_Boutique.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductRepository productRepository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            productRepository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(productRepository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
