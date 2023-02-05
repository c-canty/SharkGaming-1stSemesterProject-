using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminMotherboardEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public Motherboard motherboard { get; set; }

        public AdminMotherboardEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            motherboard = _productService.GetMotherboards(id);
            if (motherboard == null)
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
            _productService.UpdateMotherboards(motherboard);
            return RedirectToPage("AdminMotherboardListPage");
        }
    }
}

