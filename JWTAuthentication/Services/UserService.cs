using JWTAuthentication.Entities;
using JWTAuthentication.Helpers;

namespace JWTAuthentication.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Insert(User user);
    }

    public class UserService : IUserService
    {
        public UserService() { }

        public User Insert(User user)
        {
            user.Id = UserList.GetId();
            UserList.Users.Add(user);
            return user;
        }
        
        public User GetById(int id)
        {
            var user = UserList.Users.FirstOrDefault(x => x.Id == id);
            if (user == null) throw new KeyNotFoundException("User not found");
            return user;
        }
        
        public IEnumerable<User> GetAll()
            => UserList.Users;
    }
}
