namespace api.Model
{
    public class SubdivisionDTO
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int? SupervisorId { get; set; }

        public string Name { get; set; } = null!;
    }
}
