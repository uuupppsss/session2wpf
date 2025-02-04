namespace api.Model
{
    public class EducationDTO
    {
        public int Id { get; set; }

        public DateOnly DateStart { get; set; }

        public DateOnly DateEnd { get; set; }

        public int ClassificationId { get; set; }

        public string? Description { get; set; }
        public EducationClassification Classification { get; set; } = null!;
    }
}
