using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using hackathon.Data;
using hackathon.Models;

namespace hackathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ShopDbContext _context;

        public CompanyController(ShopDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Company>> Get()
          => await _context.Companies.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(Company), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetById(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            return company == null ? NotFound() : Ok(company);
        }
        


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = company.Id }, company);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> Update(int id, Company company)
        {
            

            _context.Entry(company).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }







    }
}
