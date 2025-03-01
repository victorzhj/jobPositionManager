using server.Dtos.UserDtos;

namespace server.Services.Interfaces
{
    public interface IUserService
    {
        public Task<UserDto> Register(UserAddDto userAddDto);

        public Task<UserDto> Login(UserLoginDto userLoginDto);
        public Task<UserDto> Logout();
        public Task<UserDto> ChangeEmail(UserChangeEmailDto userChangeEmailDto);
        public Task<UserDto> ChangePassword(UserChangePasswordDto userChangePasswordDto);
        public Task<UserDto> ForgotPassword(UserForgotPasswordDto userForgotPasswordDto);
        public Task<UserDto> ForgotPasswordChangePassword(UserForgotPasswordChangePasswordDto userForgotPasswordChangePasswordDto);
        public Task<UserDto> Delete(UserDeleteDto userDeleteDto);
    }
}
