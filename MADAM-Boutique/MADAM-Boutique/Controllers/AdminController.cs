using MADAM_Boutique.Models;
using MADAM_Boutique.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADAM_Boutique.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context, IProductRepository productRepository)
        {
            _context = context; _productRepository = productRepository;
        }
      
        public ViewResult Index()
        {
            return View(_context.Products);
        }

        public IActionResult productControll()
        {
            return View();
        }

        //CRUD product
        public IActionResult Details(long ProductID)
        {
            var productDetail = _productRepository.Products.Where(p => p.ProductID == ProductID);
            return View(productDetail);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!MovieExists(product.ProductID))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //// GET: Movies/Delete/5
        //public async Task<IActionResult> Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var movie = await _context.Products
        //        .FirstOrDefaultAsync(m => m.ProductID == id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    return RedirectToAction("Index");
        //}
        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var movie = await _context.Products.FindAsync(id);
            _context.Products.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //CRUD category
        public ViewResult categoryController()
        {
            return View();
        }
    }
}

