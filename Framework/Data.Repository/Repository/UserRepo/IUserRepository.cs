using Data.Model;

namespace Data.Repository.Repository.UserRepo
{
    public interface IUserRepository
    {
        User GetUser(int id);

        Task<List<User>> GetAllUsersAsync();

        void AddUser(User user);

        void UpdateUser(User user);
    }
}
