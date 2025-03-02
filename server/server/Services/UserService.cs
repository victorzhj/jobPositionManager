using server.Dtos.UserDtos;
using server.Services.Interfaces;
using AutoMapper;
using server.Models;
using server.Exceptions;
using server.Dao;

namespace server.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IGenDao<User> _userDao;
        private readonly IConfiguration _configuration;
        private readonly IGenDao<Job> _jobDao;

        public UserService(
            IConfiguration configuration,
            IMapper mapper,
            IGenDao<User> userDao,
            IGenDao<Job> jobDao
            )
        {
            _mapper = mapper;
            _userDao = userDao;
            _configuration = configuration;
            _jobDao = jobDao;
        }


        public Task<UserDto> ChangeEmail(UserChangeEmailDto userChangeEmailDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> ChangePassword(UserChangePasswordDto userChangePasswordDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Delete(UserDeleteDto userDeleteDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> ForgotPassword(UserForgotPasswordDto userForgotPasswordDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> ForgotPasswordChangePassword(UserForgotPasswordChangePasswordDto userForgotPasswordChangePasswordDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Login(UserLoginDto userLoginDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Logout()
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> Register(UserAddDto userAddDto)
        {
            var existingEmail = await _userDao.GetAllAsync(filter: (user) =>
                user.Email.Equals(userAddDto.Email));
            if (existingEmail != null)
            {
                throw new ConflictException("Email already exists");
            }
            var salt = BCrypt.Net.BCrypt.GenerateSalt();
            userAddDto.Password = BCrypt.Net.BCrypt.HashPassword(userAddDto.Password, salt);
            var userRegister = _mapper.Map<User>(userAddDto);
            userRegister.Salt = salt;
            var user = await _userDao.AddAsync(userRegister);
            return _mapper.Map<UserDto>(user);
        }
    }
}
