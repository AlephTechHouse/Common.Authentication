namespace Common.Authentication.Models;

public class AuthenticationResponse
{
    public Guid? UserId { get; set; }
    public List<Guid>? RolesIds { get; set; } = new List<Guid>();
    public string JwtToken { get; set; } = string.Empty;
    public int JwtTokenExpiryTime { get; set; }
    public string? RefreshToken { get; set; }
}
