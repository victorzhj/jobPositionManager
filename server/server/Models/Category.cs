using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
