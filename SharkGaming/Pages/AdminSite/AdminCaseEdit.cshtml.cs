using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCaseEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public Cases cases { get; set; }

        public AdminCaseEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            cases = _productService.GetCases(id);
            if (cases == null)
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
            _productService.UpdateCase(cases);
            return RedirectToPage("AdminCaseListPage");
        }
    }
}
