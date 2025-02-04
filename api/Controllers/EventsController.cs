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

        [HttpGet("GetEventsList")]
        public ActionResult<List<EventDTO>> GetEventsList(int employee_id)
        {
            if(employee_id==0) return BadRequest();
            List<Event> events = context.Calendars.Where(c=>c.EmployeeId==employee_id).Select(c=>c.Event).ToList();
            if (events==null) return NotFound();
            List<EventDTO> result = new();
            foreach (Event e in events)
            {
                result.Add(new EventDTO()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Status = e.Status,
                    Description = e.Description,
                    DateEnd = e.DateEnd,
                    DateStart = e.DateStart,
                    TypeId = e.TypeId,
                });
            }
            return Ok(result);  
        }

        [HttpGet("GetEducationsList")]
        public ActionResult<List<EducationDTO>> GetEducationsList(int employee_id)
        {
            if (employee_id == 0) return BadRequest();
            List<Education> result = context.EducationEmployees.Where(i => i.EmployeeId == employee_id).Select(s=>s.Education).ToList();
            if (result == null) return NotFound();
            var list= new List<EducationDTO>();
            foreach (var item in result)
            {
                list.Add(new EducationDTO()
                {
                    Id= item.Id,
                    DateEnd=item.DateEnd,
                    DateStart=item.DateStart,
                    ClassificationId=item.ClassificationId,
                    //Classification=item.Classification,
                    Description=item.Description
                });
            }
            return Ok(list);
            
        }

        [HttpGet("GetAbsenceCalendar")]
        public ActionResult<List<EmployeesAbsenceCalendarDTO>> GetAbsenceCalendar(int employee_id)
        {
            if (employee_id == 0) return BadRequest();
            List<EmployeesAbsenceCalendar> result = context.EmployeesAbsenceCalendars.Where(c => c.EmployeeId == employee_id).ToList();
            if (result == null) return NotFound();
            List<EmployeesAbsenceCalendarDTO> list = new();
            foreach (var item in result)
            {
                list.Add(new EmployeesAbsenceCalendarDTO()
                {
                    Id = item.Id,
                    DateEnd = item.DateEnd,
                    DateStart = item.DateStart,
                    EmployeeId = item.EmployeeId,
                    ReasonId = item.ReasonId,
                    InsteadEmployeeId = item.InsteadEmployeeId
                });
            }
            return Ok(list);
        }

    }
}
