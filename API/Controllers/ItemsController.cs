using System.Text;
using System.Xml;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ToDoDbContext _dbContext;

        public ItemsController(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        // Insert a new Item to the database. Body must contain name and/or description. id is ignored.
        [HttpPost("read-from-body")]
        public async Task<IActionResult> CreateItem([FromBody] Item model) 
        {
            await _dbContext.Items.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return Created();
        }


        
        [HttpGet]
        public async Task<IActionResult> GetItems() // Return an array of all items in the format of json objects. 
        {
            var items = await _dbContext.Items.ToListAsync();

            if (items.Count == 0)
            {
                return NotFound("There is not an item in the database.");
            }

            return Ok(items);

        }

    }
}
