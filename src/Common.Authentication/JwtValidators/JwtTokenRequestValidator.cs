using System.ComponentModel.DataAnnotations;
using Common.Authentication.Models;

namespace Common.Authentication.JwtValidators;

public class JwtTokenRequestValidator
{
    public bool Validate(JwtTokenRequest request)
    {
        var validationContext = new ValidationContext(request);
        return Validator.TryValidateObject(request, validationContext, null, true);
    }
}
