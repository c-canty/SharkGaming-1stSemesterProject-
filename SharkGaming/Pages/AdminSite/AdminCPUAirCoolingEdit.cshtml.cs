using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCPUAirCoolingEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public CPUAirCooling cPUAirCooling { get; set; }

        public AdminCPUAirCoolingEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            cPUAirCooling = _productService.GetCPUAirCoolings(id);
            if (cPUAirCooling == null)
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
            _productService.UpdateCPUAirCooling(cPUAirCooling);
            return RedirectToPage("AdminCPUAirCoolingListPage");
        }
    }
}

