using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Pages.Login;
using SharkGaming.Services.ProductServiceFile;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Products;

namespace SharkGaming.Pages.ProductInfoPages
{
    public class SearchProductsPageModel : PageModel
    {
       
        public IProductService _productService;
        public IOrderRepositoryService _orderService;


        [BindProperty] public string SearchString { get; set; }
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public int maxPrice { get; set; }
        [BindProperty] public int minPrice { get; set; }
        [BindProperty] public double price { get; set; }  


        public List<Products.ProductsClass> Items { get; private set; } = new List<Products.ProductsClass>();
        

        public SearchProductsPageModel(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }

        public void OnGet()
        {
            Items = _productService.ProductNameSearch("all").ToList();
            
        }
        public IActionResult OnPostNameSearch()
        {
            
            Items = _productService.ProductNameSearch(SearchString).ToList();
            return Page();
        }
        public IActionResult OnPostAddToCart()
        {
            
            _orderService.AddToCart(productId, amount, price);
            return RedirectToPage("SearchProductsPage");
        }
        public IActionResult OnPostPriceFilter()
        {
            Items = _productService.PriceFilter(maxPrice, minPrice).ToList();
            return Page();
        }
    }
}
