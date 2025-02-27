namespace server.Dtos.UserDtos
{
    public class UserForgotPasswordChangePasswordDto
    {
        public required int Id { get; set; }
        public required string Password { get; set; }
        public required string PasswordSalt { get; set; }
    }
}
