using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace server.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Company { get; set; }
        public string? Salary { get; set; }
        public List<string>? Categories { get; set; }
        public DateOnly? DatePosted { get; set; }
        public DateOnly? DateClosing { get; set; }
        public string? Link { get; set; }
        public required bool applied { get; set; }
        public required bool gotResponse { get; set; }
        public required bool gotInterview { get; set; }
    }
}