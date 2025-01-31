namespace api.Model
{
    public class EventDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? TypeId { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public string? Status { get; set; }
    }
}
