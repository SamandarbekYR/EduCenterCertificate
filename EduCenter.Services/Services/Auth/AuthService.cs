using EduCenter.Services.Common.Security;
using EduCenter.Services.DTOs;
using EduCenter.Services.Interfaces;
using EduCenter.Services.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Services.Services.Auth
{
    public class AuthService : IAuthService
    {
        public readonly IUnitOfWork _repos;
        public readonly ITokenService _tokenService;
       
        public AuthService(IUnitOfWork repos, ITokenService tokenService)
        {
            _repos = repos;
            _tokenService = tokenService;
        }

        public async Task<(bool Result, string Token)> LoginAsync(LoginDto dto)
        {
            var user = _repos.User.GetByPhone(dto.Phone);

            if(user == null)
            {
                throw new Exception("User does not exist!");
            }
            else
            {
                if(PasswordHasher.Verify(dto.Password,user.PasswordHash, user.PaswordSalt))
                {
                    string token = _tokenService.GeneratedToken(user);
                    return (Result: true, Token: token);
                }
                else
                {
                    throw new Exception("Invalid Password!");
                }
            }
        }
    }
}
