using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.DataTransferObjects;
using Repository.Interfaces;
using AutoMapper;
using DataAccessObject;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IUsersRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public TokenController(
            IUsersRepository userRepository,
            IMapper mapper,
            IConfiguration configuration
        )
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
            this._configuration = configuration;
        }

        // api/Token => (UserLoginDTO) POST
        [HttpPost]
        public ActionResult GetUserLoginDTO(UserLoginDTO userLoginDTO)
        {
            User user = _userRepository.GetUserByCredentials(userLoginDTO.Email, userLoginDTO.Password);
            if (user == null)
            {
                return BadRequest("Invalid credentials");
            }
            var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.UserID.ToString()),
                    new Claim("FullName", user.FullName),
                    new Claim("Email", user.Email)
                   };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));

        }


        // api/Token
        [HttpGet]
        [Authorize]
        public ActionResult AccessControl()
        {
            return Ok("connection established");
        }
        


    }
}