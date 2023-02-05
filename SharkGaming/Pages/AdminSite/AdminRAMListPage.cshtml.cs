using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminRAMListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminRAMListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<RAM> ram { get; private set; }


        public void OnGet()
        {
            ram = _productService.GetRAM();
        }

        public IActionResult OnPostDeleteRAMFormJson(int ramID)
        {
            if (ramID != null)
            {
                _productService.DeleteRAM(ramID);
                return RedirectToPage("AdminRAMListPage");
            }
            return Page();

        }
    }
}
