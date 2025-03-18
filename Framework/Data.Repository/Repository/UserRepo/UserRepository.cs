using Data.Model;
using Data.Repository.DataBase;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<User>> GetAllUsersAsync()
        {
            var user = await _inventoryDbContext.Users.ToListAsync();

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
