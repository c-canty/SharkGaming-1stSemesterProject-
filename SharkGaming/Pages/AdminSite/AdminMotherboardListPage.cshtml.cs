using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminMotherboardListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminMotherboardListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<Motherboard> motherboards { get; private set; }


        public void OnGet()
        {
            motherboards = _productService.GetMotherboards();
        }

        public IActionResult OnPostDeleteMotherboardFormJson(int motherboardID)
        {
            if (motherboardID != null)
            {
                _productService.DeleteMotherboard(motherboardID);
                return RedirectToPage("AdminMotherboardListPage");
            }
            return Page();

        }
    }
}
