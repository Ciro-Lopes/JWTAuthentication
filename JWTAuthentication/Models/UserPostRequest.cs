using System.Text.Json.Serialization;

namespace JWTAuthentication.Models
{
    public class UserPostRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
