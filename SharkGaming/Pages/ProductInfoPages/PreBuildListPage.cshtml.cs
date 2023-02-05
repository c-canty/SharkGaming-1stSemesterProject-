using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages
{
    public class PreBuildListPageModel : PageModel
    {
        public string img = "/Images/Components/Case1.png";
        private IProductService _productService;
        private IOrderRepositoryService _orderRepositoryService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public PreBuildListPageModel(IProductService iproductervice, IOrderRepositoryService iorderRepositoryService )
        {
            _productService = iproductervice;
            _orderRepositoryService = iorderRepositoryService;
        }
        public List<PreBuildsClass>? preBuilds { get; private set; }


        public void OnGet()
        {
            preBuilds = _productService.GetPreBuilds();
        }

        public IActionResult OnPostAddToCart(int id)
        {
            productId = id;

            _orderRepositoryService.AddToCart(productId, 1, price);
            return RedirectToPage("PreBuildListPage");


        }
    }
}
