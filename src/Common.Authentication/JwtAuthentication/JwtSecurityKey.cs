namespace Common.Authentication.JwtAuthentication;

public class JwtSecurityKey
{
    public static string Value
    {
        get
        {
            string key = Environment.GetEnvironmentVariable("JWT_SECURITY_KEY") ?? string.Empty;
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException("JWT_SECURITY_KEY cannot be null or whitespace.", nameof(JwtSecurityKey));
            }
            return key;
        }
    }
}
