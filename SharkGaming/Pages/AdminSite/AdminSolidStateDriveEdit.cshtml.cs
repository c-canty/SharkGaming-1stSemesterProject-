using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminSolidStateDriveEditModel : PageModel
    {
        private IProductService _productService;
        [BindProperty] public SolidStateDrive solidStateDrive { get; set; }

        public AdminSolidStateDriveEditModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int id)

        {
            solidStateDrive = _productService.GetSolidStateDrives(id);
            if (solidStateDrive == null)
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
            _productService.UpdateSSD(solidStateDrive);
            return RedirectToPage("AdminSolidStateDriveListPage");
        }
    }
}
