using EduCenter.Domain.Entities.User;
using EduCenter.Services.Interfaces.Auth;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Text;
using EduCenter.Services.Common.Helpers;

namespace EduCenter.Services.Services.Auth;

public class TokenService : ITokenService
{
    private readonly IConfiguration _config;
    public TokenService(IConfiguration configuration)
    {
        this._config = configuration.GetSection("Jwt");

    }
    public string GeneratedToken(User user)
    {
        var identityClaims = new Claim[]
       {
            new Claim("Id", user.Id.ToString()),
            new Claim("Name", user.Name),
            new Claim("Phone", user.Phone),
            new Claim(ClaimTypes.Role, user.Role.ToString())
       };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecurityKey"]!));
        var keyCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        int expiresHours = int.Parse(_config["Lifetime"]!);
        var token = new JwtSecurityToken(
            issuer: _config["Issuer"],
            audience: _config["Audience"],
            claims: identityClaims,
            expires: TimeHelper.GetDateTime().AddHours(expiresHours),
            signingCredentials: keyCredentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
