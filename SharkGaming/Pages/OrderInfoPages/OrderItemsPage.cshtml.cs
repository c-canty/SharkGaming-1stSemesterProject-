using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using System.Reflection;

namespace SharkGaming.Pages.OrderInfoPages
{
    public class OrderItemsPageModel : PageModel
    {
        private IOrderRepositoryService _orderService;
        private IProductService _productService;
        [BindProperty] public int productId { get; set; }
        
        
        


        public OrderItemsPageModel(IOrderRepositoryService orderService, IProductService productService)
        {
            
            _orderService = orderService;
            _productService = productService;
            Shipping = 89;
        }

        public List<OrderItemsClass> _orderItems { get; set; }
        public List<ProductsClass> _allProducts { get; set; }
        public List<ProductsClass> _cartProducts { get; set; }
        public double? TotalPrice { get; set; }
        public int Shipping { get; set; }

       

        //public IActionResult OnGet()
        //{
        //    _orderItems = _orderService.GetFromCart();
        //    return Page();
        //}

        public IActionResult OnGet()
        {
            List<ProductsClass> _cart = new List<ProductsClass>();

            _orderItems = _orderService.GetFromCart();
            _allProducts = _productService.ProductList();


            foreach(var item in _orderItems)
            {
                foreach(var product in _allProducts)
                {
                    if(item.ProductId == product.Id)
                        _cart.Add(product);
                }
            }
            _cartProducts = _cart;
            CalculateTotalPrice();
            return Page();
        }

        public IActionResult OnPostDeleteFromCart(int productId)
        {
            if (productId != null)
            {
                _orderService.DeleteFromCart(productId);
                return RedirectToPage("OrderItemsPage");
                
            }
            return Page();
            
        }

        public double? CalculateTotalPrice()
        {
            double? totalPrice = 0;

            if(_cartProducts != null)
            {
                foreach(var orderItem in _orderItems)
                {
                    foreach (var product in _cartProducts)
                    {
                        if(orderItem.ProductId == product.Id)
                        totalPrice = totalPrice + product.Price * orderItem.Amount;
                    }
                }
                totalPrice = totalPrice + Shipping;
                
            }
            _orderService.SaveTotalPrice(totalPrice);
            return TotalPrice = totalPrice;
            
        }


    }
}
