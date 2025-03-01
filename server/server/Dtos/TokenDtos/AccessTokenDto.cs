namespace server.Dtos.TokenDtos
{
    public class AccessTokenDto
    {
        public string TokenType { get; set; } = "Bearer";
        public required string AccessToken { get; set; }
        public required int ExpiresIn { get; set; }
    }
}