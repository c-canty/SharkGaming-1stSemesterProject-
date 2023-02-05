using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminMdot2EditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public Mdot2 mdot2 { get; set; }

        public AdminMdot2EditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            mdot2 = _productService.GetMdot2s(id);
            if (mdot2 == null)
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
            _productService.UpdateMdot2(mdot2);
            return RedirectToPage("AdminMdot2ListPage");
        }
    }
}
