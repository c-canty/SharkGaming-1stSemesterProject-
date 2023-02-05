using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminPowerSupplyListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminPowerSupplyListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<PowerSupply> powerSupplies { get; private set; }


        public void OnGet()
        {
            powerSupplies = _productService.GetPowerSupply();
        }

        public IActionResult OnPostDeletePowersupplyFormJson(int psuID)
        {
            if (psuID != null)
            {
                _productService.DeletePowerSupply(psuID);
                return RedirectToPage("AdminPowerSupplyListPage");
            }
            return Page();

        }
    }
}
