namespace api.Model
{
    public class EmployeesAbsenceCalendarDTO
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateOnly DateStart { get; set; }

        public DateOnly? DateEnd { get; set; }

        public int ReasonId { get; set; }

        public int InsteadEmployeeId { get; set; }
    }
}
