using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class JobCategories
    {
        [Key]
        public int Id { get; set; }
        public required string CategoryId { get; set; }
        public required string JobId { get; set; }
    }
}
