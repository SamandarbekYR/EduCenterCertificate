using AutoMapper;
using EduCenter.Domain.Entities.User;
using EduCenter.Services.DTOs;

namespace EduCenter.Services.Mapper;

public class UserProfile: Profile
{
    public UserProfile() 
    { 
        CreateMap<UserCreateDto,User>().ReverseMap();
    }
}
