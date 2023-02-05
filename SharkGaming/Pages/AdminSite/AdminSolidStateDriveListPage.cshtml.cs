using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminSolidStateDriveListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminSolidStateDriveListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<SolidStateDrive> solidStateDrives { get; private set; }


        public void OnGet()
        {
            solidStateDrives = _productService.GetSolidStateDrives();
        }

        public IActionResult OnPostDeleteSSDFormJson(int ssdID)
        {
            if (ssdID != null)
            {
                _productService.DeleteSSD(ssdID);
                return RedirectToPage("AdminSolidStateDriveListPage");
            }
            return Page();

        }
    }
}
