using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminPrebuildsEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public PreBuildsClass preBuilds { get; set; }

        public AdminPrebuildsEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            preBuilds = _productService.GetPreBuildss(id);
            //if (preBuilds == null)
            //{
            //    return RedirectToPage("TestRoom"); //Not found ikke defineret endnu

            //}
            return Page();
        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            _productService.UpdatePreBuilds(preBuilds);
            return RedirectToPage("AdminPrebuildsListPage");
        }
    }
}
