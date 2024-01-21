using EduCenter.Services.DTOs;

namespace EduCenter.Services.Interfaces;

public interface IUserService
{
    public int Add(UserCreateDto userdto);
}
