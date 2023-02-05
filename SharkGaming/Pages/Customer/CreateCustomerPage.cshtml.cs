using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Services.CustomerServiceFile;
using SharkGaming.Users.Customer;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SharkGaming.Pages.Customer
{
    public class CreateCustomerPageModel : PageModel
    {

        private CustomerService _customerService;

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


        public CreateCustomerPageModel(CustomerService customerService)
        {
            _customerService = customerService;
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _customerService.AddCustomer(new CustomerClass(Phone, Email, Address, Postcode, Country));
            return RedirectToPage("/Login/CreateUserPage");
        }
    }
}
