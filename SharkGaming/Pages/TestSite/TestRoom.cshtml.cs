using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes;
using SharkGaming.MockData.Products.PreBuilds;
using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Services.ProductServiceFile;
using System.Runtime.CompilerServices;

namespace SharkGaming.Pages.TestSite
{
    public class TestRoomModel : PageModel
    {
        private IProductService _productService;

        public TestRoomModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }



        public List<ProductsClass> Products { get; private set; }
        public List<Cases> cases { get; private set; }
        public List<CaseFan> caseFan { get;  private set; }
        public List<CPUAirCooling> cPUAirCoolings { get; private set; }
        public List<CPUWaterCooling> cPUWaterCoolings { get; private set; }
        public List<CPU> cPU { get; private set; }
        public List<GPU> gPU { get; private set; }
        public List<Motherboard> motherboards { get; private set; }
        public List<PowerSupply> powerSupplies { get; private set; }
        public List<RAM>? ram { get; private set; }
        public List<Mdot2> mdot2s { get; private set; }
        public List<SolidStateDrive> solidStateDrives { get; private set; }


        public void OnGet()
        {
            //Products = MockPreBuilds.GetMockPreBuilds();
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



        //public List<CaseFan> component { get; private set; }

        //public List<ProductsClass> ? products { get; private set; }

        //public List<CPU> componen { get; private set; }

        ////TESTING NEXT ID NEVER TOUCH IT AGAIN

        //public void OnGet()
        //{
        //    component = MockData.MProducts.MComponents.MComponentTypes.MCooling.MockCaseFan.GetMockCaseFans();
        //    components = MockRam.GetMockRam();
        //    componen = MockCPU.GetMockCPUs();

        //}


    }

}
