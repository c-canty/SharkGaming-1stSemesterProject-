using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class MotherBoardPage2Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public MotherBoardPage2Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<Motherboard>? motherboards { get; private set; }

        public void OnGet()
        {
            motherboards = _productService.GetMotherboards();
        }

        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(19, 1, 1200.21);
            return RedirectToPage("MotherBoardPage2");
        }
    }
}
