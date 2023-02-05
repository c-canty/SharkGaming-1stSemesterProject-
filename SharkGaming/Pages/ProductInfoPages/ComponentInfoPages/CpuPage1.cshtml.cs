using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuPage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public CpuPage1Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }

        public List<CPU>? cpus { get; private set; }

        public void OnGet()
        {
            cpus = _productService.GetCPUs();
        }

        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(12, 1, 4657.26);
            return RedirectToPage("CpuPage1");
        }
    }
}
