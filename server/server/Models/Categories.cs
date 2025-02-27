using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
