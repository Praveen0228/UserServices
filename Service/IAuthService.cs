using Microsoft.AspNetCore.Identity.Data;
using UserService.DTO;
using LoginRequest = UserService.DTO.LoginRequest;
using RegisterRequest = UserService.DTO.RegisterRequest;

namespace UserService.Service
{
    public interface IAuthService
    {
         Task<bool> RegisterUserAsync(RegisterRequest request);
         Task<string?> LoginUserAsync(LoginRequest request);
    }
}
