using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class SsdPage3Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public SsdPage3Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<SolidStateDrive>? ssds { get; private set; }

        public void OnGet()
        {
            ssds = _productService.GetSolidStateDrives();
        }

        public IActionResult OnPostAddToCart()
        {

            _orderService.AddToCart(32, 1, 540);
            return RedirectToPage("SsdPage3");

        }
    }
}
