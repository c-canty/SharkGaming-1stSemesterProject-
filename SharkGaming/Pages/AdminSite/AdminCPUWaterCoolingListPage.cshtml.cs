using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCPUWaterCoolingListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminCPUWaterCoolingListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<CPUWaterCooling> cPUWaterCoolings { get; private set; }


        public void OnGet()
        {
            cPUWaterCoolings = _productService.GetCPUWaterCooling();
        }

        public IActionResult OnPostDeleteCPUWaterCoolingFormJson(int cpuWater)
        {
            if (cpuWater != null)
            {
                _productService.DeleteCPUWaterCooling(cpuWater);
                return RedirectToPage("AdminCPUWaterCoolingListPage");
            }
            return Page();

        }
    }
}
