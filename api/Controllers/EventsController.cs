using api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

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

        //[HttpGet("GetEventsListByTypeNEmployee")]
        //public ActionResult<List<Event>> GetEventsListByTypeNEmployee(int type_id, int employee_id)
        //{
        //    if (type_id <= 0) return BadRequest(); 
        //    List<Event> result=context.Events.Where(e=>e.TypeId==type_id).ToList();

        //    if (result==null) return NotFound();
        //    return Ok(result);
        //}

        [HttpGet("GetEducationsList")]
        public ActionResult<List<Education>> GetEducationsList(int employee_id)
        {
            if (employee_id == 0) return BadRequest();
            List<Education> result = context.EducationEmployees.Where(i => i.EmployeeId == employee_id).Select(s=>s.Education).ToList();
            if (result == null) return NotFound();
            return Ok(result);
            
        }

        [HttpGet("GetAbsenceCalendar")]
        public ActionResult<List<EmployeesAbsenceCalendar>> GetAbsenceCalendar(int employee_id)
        {
            if (employee_id == 0) return BadRequest();
            List<EmployeesAbsenceCalendar> result= context.EmployeesAbsenceCalendars.Where(c=>c.EmployeeId==employee_id).ToList();
            if (result == null) return NotFound();
            return Ok(result);
        }
    }
}
