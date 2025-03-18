using Data.Model;

namespace Data.Repository.Repository.OrderRepo
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);

        List<Order> GetAllOrders();

        void AddOrder(Order order);

        void UpdateOrder(Order order);
    }
}
