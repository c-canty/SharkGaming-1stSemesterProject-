using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuWaterCoolingPage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public CpuWaterCoolingPage1Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<Products.Components.ComponentTypes.Cooling.CPUWaterCooling>? cpuWaterCoolings { get; private set; }

        public void OnGet()
        {
            cpuWaterCoolings = _productService.GetCPUWaterCooling();
        }
        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(9, 1, 649);
            return RedirectToPage("CpuWaterCoolingPage1");
        }
    }
}
