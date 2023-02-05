using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminGPUListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminGPUListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<GPU> gPUs { get; private set; }


        public void OnGet()
        {
            gPUs = _productService.GetGPUs();
        }

        public IActionResult OnPostDeleteGPUFormJson(int gpuID)
        {
            if (gpuID != null)
            {
                _productService.DeleteGPU(gpuID);
                return RedirectToPage("AdminGPUListPage");
            }
            return Page();

        }
    }
}
