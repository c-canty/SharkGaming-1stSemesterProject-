using SharkGaming.Order;
using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Users.Customer;

namespace SharkGaming.OrderFile
{
    public class OrderItemsClass
    {
        public static int nextId = 0;
        public int OrderItemId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        

        public OrderItemsClass(int productId, int amount, double price)
        {
            ProductId = productId;
            Amount = amount;
            Price = price;
            OrderItemId = nextId++;

        }
        public OrderItemsClass()
        {
            
        }

        public static List<OrderItemsClass> orderItemList = new List<OrderItemsClass>()
        {
        };

        public static List<OrderItemsClass> GetOrderList()
        {
            return orderItemList;
        }


    }
}
