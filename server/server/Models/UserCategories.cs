using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class UserCategories
    {
        [Key]
        public int Id { get; set; }
        public required string CategoryId { get; set; }
        public required string UserId { get; set; }
    }
}
