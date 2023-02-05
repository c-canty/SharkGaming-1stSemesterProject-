using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;

namespace SharkGaming.Products.PreBuilds
{
    public class PreBuildsClass : ProductsClass
    {
        public string Specs { get; set; }
        public bool Discount { get; set; }

        public Cases Cases { get; set; }
        public Motherboard Motherboard { get; set; }
        public CPU CPU { get; set; }
        public CPUCooling CPUCooling { get; set; }
        public RAM rAM { get; set; }
        public GPU gPU { get; set; }
        public StorageClass storageClass { get; set; }
        public PowerSupply powerSupply { get; set; }
        public CaseFan caseFan { get; set; }



        public PreBuildsClass(string name, double price, string specs, bool discount, string img, string description, string link, Cases cases, Motherboard motherboard, CPU cPU, CPUCooling cPUCooling, RAM raM, GPU gpU, StorageClass storageclass, PowerSupply powersupply, CaseFan casefan)
            : base(name, price, img, description, link)
        {
            Specs = specs;
            Discount = discount;
            Cases = cases;
            Motherboard = motherboard;
            CPU = cPU;
            CPUCooling = cPUCooling;
            rAM = raM;
            gPU = gpU;
            storageClass = storageclass;
            powerSupply = powersupply;
            caseFan = casefan;
            Id = nextId++;

        }


        public PreBuildsClass()
        {
        }


    }
}
