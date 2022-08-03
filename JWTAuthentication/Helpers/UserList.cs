using JWTAuthentication.Entities;

namespace JWTAuthentication.Helpers
{
    public static class UserList
    {
        public static List<User> Users = new List<User>();

        public static int Id = 0;

        public static int GetId() 
        {   
            Id++;
            return Id;
        }
    }
}
