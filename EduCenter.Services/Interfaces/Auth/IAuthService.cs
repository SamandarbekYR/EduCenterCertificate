using EduCenter.Services.DTOs;

namespace EduCenter.Services.Interfaces.Auth;

public interface IAuthService
{
    public Task<(bool Result, string Token)> LoginAsync(LoginDto dto);
}
