using AutoMapper;
using server.Models;
using server.Dtos.CategoriesDtos;
using server.Dtos.UserDtos;
using server.Dtos.JobDtos;
using server.Dtos.TokenDtos;

namespace server.AutoMapperConfiguration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            // Mapping for user
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<User, UserAddDto>();
            CreateMap<UserAddDto, User>();
            CreateMap<User, UserLoginDto>();
            CreateMap<UserLoginDto, User>();
            CreateMap<User, UserDeleteDto>();
            CreateMap<UserDeleteDto, User>();
            CreateMap<User, UserChangeEmailDto>();
            CreateMap<UserChangeEmailDto, User>();
            CreateMap<User, UserChangePasswordDto>();
            CreateMap<UserChangePasswordDto, User>();
            CreateMap<User, UserForgotPasswordChangePasswordDto>();
            CreateMap<UserForgotPasswordChangePasswordDto, User>();
            CreateMap<User, UserForgotPasswordDto>();
            CreateMap<UserForgotPasswordDto, User>();

            // Mapping for job
            CreateMap<Job, JobAddDto>();
            CreateMap<JobAddDto, Job>();
            CreateMap<Job, JobDto>();
            CreateMap<JobDto, Job>();
            CreateMap<Job, JobRemoveDto>();
            CreateMap<JobRemoveDto, Job>();

            // Mapping for category
            CreateMap<Category, CategoryAddDto>();
            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryEditDto>();
            CreateMap<CategoryEditDto, Category>();
            CreateMap<Category, CategoryGetDto>();

        }
    }
}
