using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using System.Security.Cryptography.X509Certificates;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class RamPage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public RamPage1Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<RAM>? rams { get; private set; }

        public void OnGet()
        {
            rams = _productService.GetRAM();
        }

        public IActionResult OnPostAddToCart()
        {

            _orderService.AddToCart(24, 1, 543);
            return RedirectToPage("RamPage1");
            
        }
    }
}
