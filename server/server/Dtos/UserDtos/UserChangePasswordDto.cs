namespace server.Dtos.UserDtos
{
    public class UserChangePasswordDto
    {
        public required string OldPassword { get; set; }
        public required string NewPassword { get; set; }
    }
}
