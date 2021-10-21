using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finalproject018.Data;
using finalproject018.Models;

namespace finalproject018.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PaymentDetailsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.payment_details.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(PaymentDetailsModel data)
        {
            if (ModelState.IsValid)
            {
                await _context.payment_details.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.paymentDetailId }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.payment_details.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, PaymentDetailsModel item)
        {
            if (id != item.paymentDetailId)
            {
                return BadRequest();
            }

            var existItem = await _context.payment_details.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if (existItem == null)
            {
                return NotFound();
            }

            existItem.cardOwnerName = item.cardOwnerName;
            existItem.cardNumber = item.cardNumber;
            existItem.expirationDate = item.expirationDate;
            existItem.securityCode = item.securityCode;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.payment_details.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if (existItem == null)
            {
                return NotFound();
            }

            _context.payment_details.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}
