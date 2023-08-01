using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlexCore.Models.EFModels;

namespace FlexCore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Products
        //public async Task<IActionResult> Index()
        //{
        //    var appDbContext = _context.Products.Include(p => p.fk_ProductSubCategory);
        //    return View(await appDbContext.ToListAsync());
        //}

        // GET: Products/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.fk_ProductSubCategory)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["fk_ProductSubCategoryId"] = new SelectList(_context.ProductSubCategories, "ProductSubCategoryId", "ProductSubCategoryName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ProductDescription,ProductMaterial,ProductOrigin,UnitPrice,SalesPrice,StartTime,EndTime,Status,LogOut,Tag,fk_ProductSubCategoryId,CreateTime,EditTime")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["fk_ProductSubCategoryId"] = new SelectList(_context.ProductSubCategories, "ProductSubCategoryId", "ProductSubCategoryName", products.fk_ProductSubCategoryId);
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            ViewData["fk_ProductSubCategoryId"] = new SelectList(_context.ProductSubCategories, "ProductSubCategoryId", "ProductSubCategoryName", products.fk_ProductSubCategoryId);
            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProductId,ProductName,ProductDescription,ProductMaterial,ProductOrigin,UnitPrice,SalesPrice,StartTime,EndTime,Status,LogOut,Tag,fk_ProductSubCategoryId,CreateTime,EditTime")] Products products)
        {
            if (id != products.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["fk_ProductSubCategoryId"] = new SelectList(_context.ProductSubCategories, "ProductSubCategoryId", "ProductSubCategoryName", products.fk_ProductSubCategoryId);
            return View(products);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.fk_ProductSubCategory)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'AppDbContext.Products'  is null.");
            }
            var products = await _context.Products.FindAsync(id);
            if (products != null)
            {
                _context.Products.Remove(products);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexMen()
        {
            return View();
        }

        public IActionResult IndexWomen()
        {
            return View();
        }

        public IActionResult IndexKid()
        {
            return View();
        }

        private bool ProductsExists(string id)
        {
            return (_context.Products?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
