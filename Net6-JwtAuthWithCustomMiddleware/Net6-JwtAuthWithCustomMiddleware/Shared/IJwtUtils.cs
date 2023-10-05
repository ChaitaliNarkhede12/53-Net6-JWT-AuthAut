namespace Net6_JwtAuthWithCustomMiddleware.Shared
{
    public interface IJwtUtils
    {
        public string GenerateToken(User user);
        public User ValidateToken(string token);
    }
}
