using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;

namespace SharkGaming.MockData.MProducts.MOrders
{
    public class MockOrder
    {
        public static List<OrderClass> _mockOrders = new List<OrderClass>()
        {
            //new OrderClass(new Users.Customer.CustomerClass("51528341", "christian_canty@hotmail.co.uk", "Strandgade 1c, 1tv", 4300, "Denmark", "ccanty", "123"), "Strandgade 1c, 1tv, 4300 Holbæk", MockOrderItems.GetMockOrderItems())
        };

        public static List<OrderClass> GetMockOrders() { return _mockOrders; }
    }
}
