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
    public class OrdersController : ControllerBase
    {
        private readonly ShopDbContext _context;

        public OrdersController(ShopDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
          => await _context.Orders.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(Order), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetById(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            return order == null ? NotFound() : Ok(order);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Order order)
        {
            DateTime time;
            time = DateTime.Now;
            var company = await _context.Companies.FindAsync(order.FirmaId);
            
            
            if (company != null)
            {
                var start = company.sbaslagic;
                var stop = company.sbitis;
                if (company.Onay == true)
                {
                    if (time >= start  && time<=stop)
                    {

                        await _context.Orders.AddAsync(order);
                        await _context.SaveChangesAsync();
                        return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
                        
                    }
                    else
                        return BadRequest();
                }
                else
                    return BadRequest();
                
            }
            else
                return BadRequest();
            






        }





    }
}
