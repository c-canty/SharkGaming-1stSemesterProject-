using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.OrderInfoPages
{
    public class OrderConfirmationPageModel : PageModel
    {
        public List<OrderClass> orders { get; set; }
        
        private IOrderRepositoryService _orderService { get; set; }
        private IProductService _productService { get; set; }

        [BindProperty]
        public string Email { get; set; }
        public OrderClass order { get; set; }
        public double? TotalPrice { get; set; }
        

        public OrderConfirmationPageModel(IOrderRepositoryService orderRepositoryService, IProductService productService)
        {
            _orderService = orderRepositoryService;
            _productService = productService;
            

        }

        public void OnGet()
        {
           TotalPrice = _orderService.GetTotalPrice();
        }
        public IActionResult OnPostEmailConfirmation()
        {
            order = _orderService.GetOrderByEmail(Email);
            TotalPrice = _orderService.GetTotalPrice();
            return Page();

        }
        public IActionResult OnPostRefreshCart()
        {
            _orderService.RefreshCart();
            return RedirectToPage("/Index");
        }

    }
}
