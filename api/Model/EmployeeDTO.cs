namespace api.Model
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public string Initials { get; set; } = null!;

        public DateOnly? Birthday { get; set; }

        public string Phone { get; set; } = null!;

        public string Office { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int SubdivisionId { get; set; }

        public string? Ect { get; set; }

        public int? SupervisorId { get; set; }

        public int? HelperId { get; set; }

        public int JobTitleId { get; set; }

        public string? MobilePhone { get; set; }
    }
}
