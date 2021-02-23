using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADAM_Boutique.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using MADAM_Boutique.Infrastructure;

namespace MADAM_Boutique.Pages
{
    public class CartModel : PageModel
    {
        private IProductRepository repository;

        public CartModel(IProductRepository repo)
        {
            repository = repo;
        }

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returUrl)
        {
            ReturnUrl = returUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult Onpost(long productId, string returnUrl)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItems(product, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}