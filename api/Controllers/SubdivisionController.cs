using api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubdivisionController : ControllerBase
    {
        readonly User19Context context;
        public SubdivisionController(User19Context context)
        {
            this.context = context;
        }

        [HttpGet("GetSubdivisionsList")]
        public ActionResult<List<Subdivision>> GetSubdivisionsList()
        {
            List<Subdivision> result = [.. context.Subdivisions];
            if(result==null) return NotFound();
            return Ok(result);
        }
    }
}
