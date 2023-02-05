using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminMdot2ListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminMdot2ListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<Mdot2> mdot2s { get; private set; }


        public void OnGet()
        {
            mdot2s = _productService.GetMdot2();
        }

        public IActionResult OnPostDeleteMdot2FormJson(int mdot2ID)
        {
            if (mdot2ID != null)
            {
                _productService.DeleteMdot2 (mdot2ID);
                return RedirectToPage("AdminMdot2ListPage");
            }
            return Page();

        }
    }
}
