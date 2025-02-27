namespace server.Dtos.UserDtos
{
    // Currently useless but might be useful in the future if I want to
    // ímplement an email confirmation for deleting user.
    public class UserDeleteDto
    {
        public required int Id { get; set; }
        public required string Email { get; set; }
    }
}
