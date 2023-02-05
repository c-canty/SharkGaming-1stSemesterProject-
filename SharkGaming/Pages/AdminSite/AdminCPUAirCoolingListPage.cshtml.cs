using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCPUAirCoolingListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminCPUAirCoolingListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<CPUAirCooling> cPUAirCoolings { get; private set; }


        public void OnGet()
        {
            cPUAirCoolings = _productService.GetCPUAirCooling();
        }

        public IActionResult OnPostDeleteCPUAirCoolingFormJson(int cpuAirID)
        {
            if (cpuAirID != null)
            {
                _productService.DeleteCPUAirCooling(cpuAirID);
                return RedirectToPage("AdminCPUAirCoolingListPage");
            }
            return Page();

        }
    }
}
