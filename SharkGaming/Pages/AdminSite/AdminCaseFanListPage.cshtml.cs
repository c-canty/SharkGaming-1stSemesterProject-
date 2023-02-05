using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCaseFanListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminCaseFanListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }



        public List<CaseFan> caseFans { get; private set; }


        public void OnGet()
        {
            caseFans = _productService.GetCaseFan();
        }

        public IActionResult OnPostDeleteCaseFanFormJson(int caseFanID)
        {
            if (caseFanID != null)
            {
                _productService.DeleteCaseFan(caseFanID);
                return RedirectToPage("AdminCaseFanListPage");
            }
            return Page();

        }
    }
}
