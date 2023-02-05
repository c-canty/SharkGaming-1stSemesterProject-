using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.AdminSite
{
    public class AdminCaseListPageModel : PageModel
    {
        private IProductService _productService;

        public AdminCaseListPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }

        public List<Cases> cases { get; private set; }


        public void OnGet()
        {
            cases = _productService.GetCases();
        }

        public IActionResult OnPostDeleteCaseFormJson(int caseID)
        {
            if (caseID != null)
            {
                _productService.DeleteCase(caseID);
                return RedirectToPage("AdminCaseListPage");
            }
            return Page();

        }
    }
}
