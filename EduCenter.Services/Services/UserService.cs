using AutoMapper;
using EduCenter.Domain.Entities.User;
using EduCenter.Services.Common.Security;
using EduCenter.Services.DTOs;
using EduCenter.Services.Interfaces;
using EduCenter.Services.Interfaces.Auth;

namespace EduCenter.Services.Services;

public class UserService : IUserService
{
    private IUnitOfWork _repos;
    private IMapper _mapper;
    private readonly ITokenService _tokenService;

    public UserService(IUnitOfWork unitOf, IMapper mapper,
        ITokenService tokenService)
    {
        _repos = unitOf;
        _mapper = mapper;
        _tokenService = tokenService;
    }


    public int Add(UserCreateDto userdto)
    {
        try
        {
            //User user = _mapper.Map<User>(userdto);
            User user = new User();
            user.Name = userdto.Name;
            user.Phone = userdto.Phone;
            user.PaswordSalt = PasswordHasher.Hash(userdto.Password).Salt;
            user.PasswordHash = PasswordHasher.Hash(userdto.Password).Hash;

            _repos.User.Add(user);
            int a = _repos.SaveChanges();

            return a;
        }
        catch
        {
            return 0;
        }
    }
}
