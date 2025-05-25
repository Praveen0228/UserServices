namespace UserService.DTO
{
    public record RegisterRequest(string Email, string Username, string Password);
    public record LoginRequest(string Email, string Password);
}
