using Microsoft.AspNetCore.Mvc;
using ToDo.API.Data;

namespace ToDo.API.Controllers
{
    [Route("api/[controller]")]
    public class ConfigController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Config.Statues);
        }
    }
}
