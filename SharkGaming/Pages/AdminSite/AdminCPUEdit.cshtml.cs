using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCPUEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public CPU cPU { get; set; }

        public AdminCPUEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            cPU = _productService.GetCPUs(id);
            if (cPU == null)
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
            _productService.UpdateCPU(cPU);
            return RedirectToPage("AdminCPUListPage");
        }
    }
}

