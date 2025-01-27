using api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly User19Context context;
        public EmployeesController(User19Context context)
        {
            this.context = context;
        }
        [HttpGet("GetEmployeesList")]
        public ActionResult<List<Employee>> GetEmployeesList(int subdivision_id)
        {
            if (subdivision_id == 0) return BadRequest();
            List<Employee> employees = [.. context.Employees.Where(e=>e.SubdivisionId==subdivision_id)];
            if (employees == null) return NotFound();
            return Ok(employees);
        }
    }
}
