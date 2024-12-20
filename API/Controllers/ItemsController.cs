using System.Text;
using System.Xml;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost("read-from-body")]
        public async Task<IActionResult> CreateItem([FromBody] Item model)
        {
            await _dbContext.Items.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return Ok("Item added to database");
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _dbContext.Items.ToList();
            return Ok(items);
        }
    }
}
