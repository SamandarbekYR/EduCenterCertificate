using EduCenter.Domain.Entities.User;

namespace EduCenter.Services.Interfaces.Auth;

public interface ITokenService
{
    public string GeneratedToken(User? user);
}
