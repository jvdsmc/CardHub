using CardHub.API.DTOs;
using CardHub.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CardHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterUserDto dto)
        {
            try
            {
                var user = _authService.Register(dto);
                return CreatedAtAction(nameof(Register), new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUserDto dto)
        {
            try
            {
                var token = _authService.Login(dto);
                return Ok(new { token });
            }
            catch (Exception ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }
    }
}