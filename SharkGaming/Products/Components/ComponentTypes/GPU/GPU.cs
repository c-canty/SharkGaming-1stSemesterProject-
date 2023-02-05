namespace SharkGaming.Products.Components.ComponentTypes.GPU
{
    public class GPU : ComponentsClass
    {
        public string GraphicsEngine { get; set; }
        public int CUDACore { get; set; }
        public bool VRReady { get; set; }
        public string MaxResolution { get; set; }
        public int MemorySize { get; set; }
        public string MemoryTechnology { get; set; }
        public int MemoryBusWidth { get; set; }
        public int RequriedPowerSupply { get; set; }
        public double Width { get; set; }
        public double PCIExpress { get; set; }

        public GPU(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, string graphicsEngine, int cUDACore, bool vRReady, string maxResolution, int memorySize, string memoryTechnology, int memoryBusWidth, int requriedPowerSupply, double width, double pCIExpress, string img, string description, string link)
            : base(name, price, amdCompatible, intelCompatible, specInfo, img, description, link)
        {
            GraphicsEngine = graphicsEngine;
            CUDACore = cUDACore;
            VRReady = vRReady;
            MaxResolution = maxResolution;
            MemorySize = memorySize;
            MemoryTechnology = memoryTechnology;
            Width = width;
            PCIExpress = pCIExpress;
            Id = nextId++;
        }

        public GPU()
        {

        }


    }
}
