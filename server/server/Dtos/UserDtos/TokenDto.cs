namespace server.Dtos.UserDtos
{
    public class TokenDto
    {
        public string TokenType { get; set; } = "Bearer";
        public required string AccessToken { get; set; }
        public required int ExpiresIn { get; set; }
    }
}