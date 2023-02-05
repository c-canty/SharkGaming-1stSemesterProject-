using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuWaterCoolingPage2Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public CpuWaterCoolingPage2Model(IProductService productService, IOrderRepositoryService orderService)
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
            _orderService.AddToCart(10, 1, 999);
            return RedirectToPage("CpuWaterCoolingPage2");
        }
    }
}
