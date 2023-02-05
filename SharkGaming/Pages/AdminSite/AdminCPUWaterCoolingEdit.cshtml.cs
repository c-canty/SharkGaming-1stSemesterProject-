using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCPUWaterCoolingEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public CPUWaterCooling cPUWaterCooling { get; set; }

        public AdminCPUWaterCoolingEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            cPUWaterCooling = _productService.GetCPUWaterCoolings(id);
            if (cPUWaterCooling == null)
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
            _productService.UpdateCPUWaterCooling(cPUWaterCooling);
            return RedirectToPage("AdminCPUWaterCoolingListPage");
        }
    }
}

