using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using hackathon.Data;
using hackathon.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace hackathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        

        private readonly ShopDbContext _context;
        

        public ProductsController(ShopDbContext context) => _context = context;

        

        [HttpGet]
        public async Task<IEnumerable<Products>> Get()
          => await _context.Products.ToListAsync();


        [HttpGet("id")]
        [ProducesResponseType(typeof(Products), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetById(int id)
        {
              var products = await _context.Products.FindAsync(id);
            return products == null ? NotFound() : Ok(products);
        }

       

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Products products)
        {

            var company = await _context.Companies.FindAsync(products.FirmaId);
            if (company!=null)
            {
                await _context.Products.AddAsync(products);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetById), new { id = products.Id }, products);
            }
            else
                return BadRequest();



        }



    }
}
