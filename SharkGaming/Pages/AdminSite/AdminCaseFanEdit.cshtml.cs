using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCaseFanEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public CaseFan caseFan { get; set; }

        public AdminCaseFanEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            caseFan = _productService.GetCaseFans(id);
            if (caseFan == null)
            {
                return RedirectToPage("TestRoom"); //Not found ikke defineret endnu

            }
            return Page();
        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            _productService.UpdateCaseFan(caseFan);
            return RedirectToPage("AdminCaseFanListPage");
        }
    }
}
