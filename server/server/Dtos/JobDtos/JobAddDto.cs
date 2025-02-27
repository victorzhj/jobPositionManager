namespace server.Dtos.JobDtos
{
    public class JobAddDto
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Company { get; set; }
        public string? Salary { get; set; }
        public List<string>? Categories { get; set; }
        public DateOnly? DatePosted { get; set; }
        public DateOnly? DateClosing { get; set; }
        public string? Link { get; set; }
        public required bool Applied { get; set; }
        public required bool GotResponse { get; set; }
        public required bool GotInterview { get; set; }
    }
}
