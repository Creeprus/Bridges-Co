using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BridgesCoModels.Context;
using BridgesCoModels.Models;

namespace BridgeCoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderClientsController : ControllerBase
    {
        private readonly BridgesCOContext _context;

        public OrderClientsController(BridgesCOContext context)
        {
            _context = context;
        }

        // GET: api/OrderClients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderClient>>> GetOrderClient()
        {
            return await _context.OrderClient.Include(x=>x.Order_Id).Include(x=>x.Account_Id).ToListAsync();
        }

        // GET: api/OrderClients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderClient>> GetOrderClient(int id)
        {
            var orderClient = await _context.OrderClient.FindAsync(id);

            if (orderClient == null)
            {
                return NotFound();
            }
            await _context.Entry(orderClient).Reference(x => x.Account_Id).LoadAsync();
            await _context.Entry(orderClient).Reference(x => x.Order_Id).LoadAsync();
            return orderClient;
        }

        // PUT: api/OrderClients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderClient(int id, OrderClient orderClient)
        {
            if (id != orderClient.Id_OrderClient)
            {
                return BadRequest();
            }

            _context.Entry(orderClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderClientExists(id))
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

        // POST: api/OrderClients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderClient>> PostOrderClient(OrderClient orderClient)
        {
            _context.OrderClient.Add(orderClient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderClient", new { id = orderClient.Id_OrderClient }, orderClient);
        }

       
        private bool OrderClientExists(int id)
        {
            return _context.OrderClient.Any(e => e.Id_OrderClient == id);
        }
    }
}
