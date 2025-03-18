using Data.Model;
using Data.Repository.DataBase;

namespace Data.Repository.Repository.OrderRepo
{
    public class OrderRepository : IOrderRepository
    {
        private InventoryDbContext _inventoryDbContext;

        public OrderRepository(InventoryDbContext dBContext)
        {
            _inventoryDbContext = dBContext;
        }

        public Order GetOrder(int id)
        {
            var order = _inventoryDbContext.Orders.FirstOrDefault(x => x.OrderId == id);

            return order;
        }

        public List<Order> GetAllOrders()
        {
            var order = _inventoryDbContext.Orders.ToList();

            return order;
        }

        public void AddOrder(Order order)
        {
            _inventoryDbContext.Orders.Add(order);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _inventoryDbContext.SaveChanges();
        }
    }
}
