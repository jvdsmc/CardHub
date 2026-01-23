using CardHub.API.DTOs;
using CardHub.API.Models;

namespace CardHub.API.Services
{
    public interface IAuthService
    {
        User Register(RegisterUserDto dto);
        string Login(LoginUserDto dto);
    }
}