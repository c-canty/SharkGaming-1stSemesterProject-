using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CaseFanPage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public CaseFanPage1Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<CaseFan> caseFans { get; set; }
        public List<ProductsClass> orderItemList { get; set; }
        public List<Products.ProductsClass> Items { get; private set; } = new List<Products.ProductsClass>();

        public void OnGet()
        {
            caseFans = _productService.GetCaseFan();
        }

        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(3, 1, 59);
            return RedirectToPage("CaseFanPage1");
        }
    }
}
