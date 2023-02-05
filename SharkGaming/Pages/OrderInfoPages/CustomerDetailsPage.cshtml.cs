using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Services.CustomerServiceFile;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using SharkGaming.Users.Customer;
using System.Collections.Generic;

namespace SharkGaming.Pages.OrderInfoPages
{
    public class CustomerDetailsPageModel : PageModel
    {

        private CustomerService _customerService;
        private IOrderRepositoryService _orderService;
        private IProductService _productService;

        [BindProperty]
        public int Phone { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Address { get; set; }

        [BindProperty]
        public int Postcode { get; set; }

        [BindProperty]
        public string Country { get; set; }

        public double? TotalPrice { get; set; }
        public int Shipping { get; set; }
        



       


        public CustomerDetailsPageModel(CustomerService customerService, IOrderRepositoryService orderService, IProductService productService)
        {
            _customerService = customerService;
            _orderService = orderService;
            _productService = productService;
            
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _orderService.CreateOrder(new CustomerClass(Phone, Email, Address, Postcode, Country), TotalPrice);
            
            
            return RedirectToPage("OrderConfirmationPage");
        }
        
        
    }
}

