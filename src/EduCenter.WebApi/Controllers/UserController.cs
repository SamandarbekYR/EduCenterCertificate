using EduCenter.Services.DTOs;
using EduCenter.Services.Interfaces;
using EduCenter.Services.Interfaces.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCenter.WebApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IAuthService _authService;
        public UserController(IUserService service, IAuthService authService)
        {
            _service = service;
            _authService = authService;
        }

        [HttpPost]
        // [Authorize(Roles = "Admin")]
        [AllowAnonymous]
        public IActionResult CreateUser(UserCreateDto dto)
         => Ok(_service.Add(dto));

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login(LoginDto dto)
        => Ok(_authService.LoginAsync(dto));
    }
}
