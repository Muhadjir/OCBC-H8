using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        // private readonly ApiDbContext _context;

        // public TodoController(ApiDbContext context)
        // {
        //     _context = context;
        // }

        // [HttpGet]
        // public async Task<ActionResult> GetItems()
        // {
        //     var items = await _context.Items.ToListAsync();
        //     return Ok(items);
        // }

        // [HttpPost]
        // public async Task<ActionResult> CreateItem(ItemData data)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         await _context.Items.AddAsync(data);
        //         await _context.SaveChangesAsync();
                
        //         return CreatedAtAction("GetItem", new{data.Id}, data);
        //     }

        //     return new JsonResult("Something went wrong"){StatusCode=500};
        // }

        // [HttpGet]
        // public async Task<ActionResult> GetItems(int id)
        // {
        //     var items = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
        //     if(items == null)
        //         return NotFound();

        //     return Ok(items);
        // }





        [Route("TestRun")]
        [HttpGet]
        
        public ActionResult TestRun()
        {
            return Ok("success");
        }
    }
}