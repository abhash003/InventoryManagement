using Data.Model;
using Data.Repository.DataBase;

namespace Data.Repository.Repository.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private InventoryDbContext _inventoryDbContext;

        public UserRepository(InventoryDbContext dBContext)
        {
            _inventoryDbContext = dBContext;
        }

        public User GetUser(int id)
        {
            var user = _inventoryDbContext.Users.FirstOrDefault(x => x.UserId == id);

            return user;
        }

        public List<User> GetAllUsers()
        {
            var user = _inventoryDbContext.Users.ToList();

            return user;
        }

        public void AddUser(User user)
        {
            _inventoryDbContext.Users.Add(user);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _inventoryDbContext.SaveChanges();
        }
    }
}
