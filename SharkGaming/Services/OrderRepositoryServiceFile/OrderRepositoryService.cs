using SharkGaming.MockData.MProducts.MComponents.MComponentTypes;
using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.JsonServiceFile;
using SharkGaming.Users.Customer;
using SharkGaming.Products.PreBuilds;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace SharkGaming.Services.OrderRepositoryServiceFile
{
    public class OrderRepositoryService : IOrderRepositoryService
    {
        private List<OrderClass> _orders;
        private List<OrderItemsClass> _orderItems;
        public double? TotalPrice { get; set; }

        public OrderRepositoryService()
        {
            _orders = OrderClass.GetOrders();
            _orderItems = OrderItemsClass.GetOrderList();
        }

        #region json
        private JsonService JsonService { get; set; }

        public OrderRepositoryService(JsonService jsonService)
        {
            JsonService = jsonService;
            //_orders = JsonService.GetJsonOrder().ToList();
            _orderItems = JsonService.GetJsonOrderItems().ToList();
            JsonService.SaveJsonOrderItems(_orderItems);
        }
        #endregion

        public List<OrderClass> GetOrders()
        {
            return _orders;
        }
       
        public void AddOrder(OrderClass order)
        {
            _orders.Add(order);
            JsonService.SaveJsonOrder(_orders);
        }
        
        public void CreateOrder(CustomerClass customer, double? totalPrice)
        {
            _orders = OrderClass.GetOrders();
            _orders.Add(new OrderClass(customer, customer.Address, _orderItems, totalPrice));
            JsonService.SaveJsonOrder(_orders);          
        }
        

        public void UpdateOrder(OrderClass order)

        {
            if (order != null)
            {
                foreach (OrderClass i in _orders)
                {
                    if (i.Id == order.Id)
                    {
                        i.Customer.Email = order.Customer.Email;
                        //i.TotalPrice = order.TotalPrice;
                    }
                    JsonService.SaveJsonOrder(_orders);
                }
            }
        }

        public OrderClass GetOrderById(int id)
        {
            if (id != null)
            {
                foreach (OrderClass i in _orders)

                    if (i.Id == id)
                    {
                        return i;
                    }

            }
            return null;
        }
        public OrderClass GetOrderByEmail(string email)
        {
            if (email != null)
            {
                foreach (OrderClass i in _orders)

                    if (i.Customer.Email == email)
                    {
                        return i;
                    }

            }
            return null;
        }

        public IEnumerable<OrderClass> CustomerEmailSearch(OrderClass order)
        {
            List<OrderClass> emailSearch = new List<OrderClass>();
            {
                if (!string.IsNullOrWhiteSpace(order.Customer.Email))
                {
                    foreach (OrderClass item in _orders)
                    {
                        if (item.Customer.Email.ToLower().Contains(order.Customer.Email.ToLower()))
                        {
                            emailSearch.Add(item);
                        }
                    }
                }
                return emailSearch;
            }
        }

        public OrderClass DeleteOrder(int? orderId)
        {

            OrderClass orderToBeDeleted = null;
            foreach (OrderClass item in _orders)
            {
                if (item.Id == orderId)
                {
                    orderToBeDeleted = item;
                    break;
                }
            }
            if (orderToBeDeleted != null)
            {
                _orders.Remove(orderToBeDeleted);
                JsonService.SaveJsonOrder(_orders);

            }
            return orderToBeDeleted;
        }


        //OrderItemsMethods:

        public List<OrderItemsClass> GetOrderItems()
        {
            return _orderItems;
        }

        #region Delete OrderItem
        public OrderItemsClass DeleteFromCart(int? productId)
        {
            OrderItemsClass orderItemsToBeDeleted = null;
            foreach (var item in _orderItems)
            {
                if (item.ProductId != productId)
                {
                    orderItemsToBeDeleted = item;
                    break;
                }
                orderItemsToBeDeleted = item;
                break;

            }
            if (orderItemsToBeDeleted != null)
            {
                _orderItems.Remove(orderItemsToBeDeleted);
                JsonService.SaveJsonOrderItems(_orderItems);
                
            }

            return orderItemsToBeDeleted;
        }
        #endregion


        public void AddToCart(int productId, int amount, double price)
        {
            _orderItems = OrderItemsClass.GetOrderList();          
            bool containsItem = _orderItems.Any(item => item.ProductId == productId);
            foreach (var item in _orderItems)
            {
                if (item.ProductId == productId)
                {
                    item.Amount = item.Amount + amount;
                }
            }
            if(!containsItem)
            {
                _orderItems.Add(new OrderItemsClass(productId, amount, price));
            }

            JsonService.SaveJsonOrderItems(_orderItems);
        }

        public List<OrderItemsClass> GetFromCart()
        {
            return _orderItems;
      
        }

        public void SaveTotalPrice(double? totalPrice)
        {
            TotalPrice = totalPrice;
        }
        public double? GetTotalPrice()
        {
            return TotalPrice;
        }
        public void RefreshCart()
        {
            _orderItems.Clear();
        }
    }
}
