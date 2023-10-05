namespace Net6_JwtAuthWithCustomMiddleware
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
