using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Users.Customer;

namespace SharkGaming.Services.OrderRepositoryServiceFile
{
    public interface IOrderRepositoryService
    {

        List<OrderClass> GetOrders();
        
        void AddOrder(OrderClass order);
        
        void UpdateOrder(OrderClass order);
        
        OrderClass GetOrderById(int id);

        IEnumerable<OrderClass> CustomerEmailSearch(OrderClass order);

        OrderClass DeleteOrder(int? orderId);

        //OrderItemsMethods:

       
        List<OrderItemsClass> GetOrderItems();

        OrderItemsClass DeleteFromCart(int? productId);

        void AddToCart(int productId, int amount, double price);
        
         List<OrderItemsClass> GetFromCart();
        void CreateOrder(CustomerClass customer, double? totalPrice);
        OrderClass GetOrderByEmail(string email);
        void SaveTotalPrice(double? totalPrice);
        double? GetTotalPrice();
        void RefreshCart();

    }
}
