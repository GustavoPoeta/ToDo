using System.Text;
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
        public IActionResult CreateItem([FromBody] Item model)
        {
            var message = $"message: {model.Id}, {model.Name}, {model.Description}";
            return Ok(message);
        }
    }
}
