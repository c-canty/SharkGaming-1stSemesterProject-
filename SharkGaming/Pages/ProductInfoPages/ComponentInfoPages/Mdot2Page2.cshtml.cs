using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class Mdot2Page2Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public Mdot2Page2Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<Mdot2>? mdot2 { get; private set; }

        public void OnGet()
        {
            mdot2 = _productService.GetMdot2();
        }
        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(28, 1, 1346.4);
            return RedirectToPage("Mdot2Page2");
        }
    }
}
