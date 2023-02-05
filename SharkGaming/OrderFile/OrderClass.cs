using SharkGaming.OrderFile;
using SharkGaming.Users.Customer;

namespace SharkGaming.Order
{
    public class OrderClass
    {
        public static int nextId = 0;
        public int Id { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime Dt { get; set; }
        public CustomerClass Customer { get; set; }
        public double? TotalPrice { get; set; }

        public List<OrderItemsClass> _orderItems = new List<OrderItemsClass>();
        private static List<OrderClass> _orders = new List<OrderClass>();

        public OrderClass(CustomerClass customer, string deliveryAdress, List<OrderItemsClass> orderitems, double? totalPrice)
        {
            Id = nextId++;
            Customer = customer;
            DeliveryAddress = deliveryAdress;
            Dt = DateTime.Now;
            _orderItems = orderitems;
            //TotalPrice = CalculateTotalPrice();
            _orders.Add(this);
            TotalPrice = totalPrice;
        }

        public OrderClass()
        {

        }

        public List<OrderItemsClass> GetOrderItems()
        {
            return _orderItems;
        }

        public static List<OrderClass> GetOrders()
        {
            return _orders;
        }
        //public double? CalculateTotalPrice()
        //{
        //    double? totalPrice = 0;

        //    if (_orderItems != null)
        //    {
        //        foreach (OrderItemsClass item in _orderItems)
        //        {
        //            totalPrice = totalPrice + item.Price + 1000;
        //        }
        //        return totalPrice;
        //    }
        //    return 0;
        //}

    }
}
