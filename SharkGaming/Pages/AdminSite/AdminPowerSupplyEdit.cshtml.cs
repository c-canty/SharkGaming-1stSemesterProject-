using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminPowerSupplyEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public PowerSupply powerSupply { get; set; }

        public AdminPowerSupplyEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            powerSupply = _productService.GetPowerSupplys(id);
            if (powerSupply == null)
            {
                return RedirectToPage("TestRoom"); //Not found ikke defineret endnu

            }
            return Page();
        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            _productService.UpdatePowerSupply(powerSupply);
            return RedirectToPage("AdminPowerSupplyListPage");
        }
    }
}
