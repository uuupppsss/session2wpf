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
        public ActionResult<List<SubdivisionDTO>> GetSubdivisionsList()
        {
            List<SubdivisionDTO> result = [];
            foreach (var s in context.Subdivisions)
            {
                result.Add(new SubdivisionDTO()
                {
                    Id = s.Id,
                    Description = s.Description,
                    SupervisorId = s.SupervisorId,
                    Name = s.Name
                });
            }
            if(result==null) return NotFound();
            return Ok(result);
            
        }
    }
}
