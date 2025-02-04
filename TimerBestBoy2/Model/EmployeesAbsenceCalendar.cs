using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerBestBoy2.Model
{
    public class EmployeesAbsenceCalendar
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateOnly DateStart { get; set; }

        public DateOnly? DateEnd { get; set; }

        public int ReasonId { get; set; }

        public int InsteadEmployeeId { get; set; }
    }
}
