using api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        readonly User19Context context;
        public EventsController(User19Context context) 
        {
            this.context = context;
        }

        [HttpGet("GetStudiesList")]
        public ActionResult<List<Event>> GetStudiesList()
        {

        }
    }
}
