using Data.Model;

namespace Data.Repository.Repository.UserRepo
{
    public interface IUserRepository
    {
        User GetUser(int id);

        List<User> GetAllUsers();

        void AddUser(User user);

        void UpdateUser(User user);
    }
}
