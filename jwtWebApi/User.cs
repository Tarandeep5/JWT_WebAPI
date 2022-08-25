namespace jwtWebApi
{
    public class User
    {

        public String Username { get; set; } = String.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }    
    }
}
