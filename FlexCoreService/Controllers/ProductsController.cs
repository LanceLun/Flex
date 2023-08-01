using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlexCoreService.Models.EFModels;
using Microsoft.AspNetCore.Cors;
using FlexCoreService.ProductCtrl.Interface;
using FlexCoreService.ProductCtrl.Models.VM;
using FlexCoreService.ProductCtrl.Service;
using FlexCoreService.ProductCtrl.Exts;

namespace FlexCoreService.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _db;
        private IProductRepository _repo;

        public ProductsController(AppDbContext context, IProductRepository repo)
        {
            _db = context;
            _repo = repo;
        }

        // POST: api/Products/
        [HttpPost]
        public async Task<ActionResult<IEnumerable<ProductCardVM>>> GetAllProducts()
        {
            var server = new ProductService(_repo);
            var products = server.SearchProducts().Select(p => p.ToCardVM()).ToList();
            if (products.Count == 0)
            {
                return NotFound();
            }
            return products;
        }

        // POST: api/Products
        [HttpPost("Men")]
        public async Task<ActionResult<IEnumerable<ProductCardVM>>> GetMenProducts()
        {
            string salesName = "男";
            var server = new ProductService(_repo);
            var products = server.SearchSalesProducts(salesName).Select(p => p.ToCardVM()).ToList();
            if (products.Count == 0)
            {
                return NotFound();
            }
            return products;
        }
        // POST: api/Products
        [HttpPost("Women")]
        public async Task<ActionResult<IEnumerable<ProductCardVM>>> GetWomenProducts()
        {
            string salesName = "女";
            var server = new ProductService(_repo);
            var products = server.SearchSalesProducts(salesName).Select(p => p.ToCardVM()).ToList();
            if (products.Count == 0)
            {
                return NotFound();
            }
            return products;
        }

        // POST: api/Products
        [HttpPost("Kid")]
        public async Task<ActionResult<IEnumerable<ProductCardVM>>> GetKidProducts()
        {
            string salesName = "童";
            var server = new ProductService(_repo);
            var products = server.SearchSalesProducts(salesName).Select(p => p.ToCardVM()).ToList();
            if (products.Count == 0)
            {
                return NotFound();
            }
            return products;
        }


        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
        {
            if (_db.Products == null)
            {
                return NotFound();
            }
            return await _db.Products.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProducts(string id)
        {
            if (_db.Products == null)
            {
                return NotFound();
            }
            var products = await _db.Products.FindAsync(id);

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts(string id, Products products)
        {
            if (id != products.ProductId)
            {
                return BadRequest();
            }

            _db.Entry(products).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Products>> PostProducts(Products products)
        //{
        //    if (_db.Products == null)
        //    {
        //        return Problem("Entity set 'AppDbContext.Products'  is null.");
        //    }
        //    _db.Products.Add(products);
        //    await _db.SaveChangesAsync();

        //    return CreatedAtAction("GetProducts", new { id = products.ProductId }, products);
        //}

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducts(string id)
        {
            if (_db.Products == null)
            {
                return NotFound();
            }
            var products = await _db.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }

            _db.Products.Remove(products);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductsExists(string id)
        {
            return (_db.Products?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
