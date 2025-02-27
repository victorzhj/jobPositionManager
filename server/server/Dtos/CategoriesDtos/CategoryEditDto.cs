namespace server.Dtos.CategoriesDtos
{
    public class CategoryEditDto
    {
        public required int Id { get; set; }
        public string? Name { get; set; }
        public string? JobId { get; set; }
    }
}
