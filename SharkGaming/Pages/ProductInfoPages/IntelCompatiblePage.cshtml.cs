using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages
{
    public class IntelCompatiblePageModel : PageModel
    {
       
        
            public bool Bool = false;
            public List<ProductsClass> Products { get; private set; }
            public List<Cases> cases { get; private set; }
            public List<CaseFan> caseFan { get; private set; }
            public List<CPUAirCooling> cPUAirCoolings { get; private set; }
            public List<CPUWaterCooling> cPUWaterCoolings { get; private set; }
            public List<CPU> cPU { get; private set; }
            public List<GPU> gPU { get; private set; }
            public List<Motherboard> motherboards { get; private set; }
            public List<PowerSupply> powerSupplies { get; private set; }
            public List<RAM>? ram { get; private set; }
            public List<Mdot2> mdot2s { get; private set; }
            public List<SolidStateDrive> solidStateDrives { get; private set; }

            private IProductService _productService;

            public List<ProductsClass> Items { get; private set; } = new List<ProductsClass>();

            public IntelCompatiblePageModel(IProductService iproductService)
            {
                _productService = iproductService;
            }
            public void OnGet()
            {
                cases = _productService.GetCases();
                caseFan = _productService.GetCaseFan();
                cPUAirCoolings = _productService.GetCPUAirCooling();
                cPUWaterCoolings = _productService.GetCPUWaterCooling();
                cPU = _productService.GetCPUs();
                gPU = _productService.GetGPUs();
                motherboards = _productService.GetMotherboards();
                powerSupplies = _productService.GetPowerSupply();
                ram = _productService.GetRAM();
                mdot2s = _productService.GetMdot2();
                solidStateDrives = _productService.GetSolidStateDrives();
            }

       


    }
}
