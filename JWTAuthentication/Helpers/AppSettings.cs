namespace JWTAuthentication.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }

        // automatically deleted from the database after this time
        public int RefreshTokenTTL { get; set; }
        public int ExpirationToken { get; set; }
        public int ExpirationRefreshToken { get; set; }
    }
}
