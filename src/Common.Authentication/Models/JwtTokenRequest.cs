using Common.Authentication.Attributes;

namespace Common.Authentication.Models;

public class JwtTokenRequest
{
    [RequiredGuid]
    public Guid? UserId { get; set; }

    [RequiredGuidList]
    public List<Guid>? RolesIds { get; set; } = new List<Guid>();
}
