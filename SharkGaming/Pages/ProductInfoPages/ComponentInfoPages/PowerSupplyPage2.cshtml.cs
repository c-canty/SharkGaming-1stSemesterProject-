using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class PowerSupplyPage2Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public PowerSupplyPage2Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<PowerSupply>? powerSupply { get; private set; }

        public void OnGet()
        {
            powerSupply = _productService.GetPowerSupply();
        }

        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(22, 1, 784.76);
            return RedirectToPage("PowerSupplyPage2");
        }
    }
}
