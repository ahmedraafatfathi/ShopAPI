using AutoMapper;
using Entities;
using Entities.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Services.CategoryService;
using Services.UserService;
using ShopAPI.Models;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{

    [ApiController]
    [Route("api/User")]
    [AllowAnonymous]
    [SwaggerTag("User controller")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;
        public UserController(IServiceProvider serviceProvider, IUserService userService, IMapper mapper
            , IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
            _configuration = configuration;
        }


        private string GenerateJSONWebToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var isAdmin = user.UserRole.Role.Contains("admin") ? true : false;

            List<Claim> claims = new List<Claim>()
            {
                new Claim("UserName", user.UserName),
                new Claim("IsAdmin", isAdmin.ToString())
            };

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
              _configuration["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost("Register")]
        public async Task<ResponseObject<bool>> Register(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var result = await _userService.AddUser(user);
            return _mapper.Map<ResponseObject<bool>>(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            IActionResult response = Unauthorized();
            var user = await _userService.Login(login.UsernameLogin, login.PasswordLogin);

            if (user != null)
            {
                var tokenString =  GenerateJSONWebToken(user.Data);
                response = Ok(new { token = tokenString });
            }

            return response;
        }


        
    }
}
