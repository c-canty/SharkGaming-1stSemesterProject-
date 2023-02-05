using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products;
using SharkGaming.Products.PreBuilds;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace SharkGaming.MockData.Products.PreBuilds
{
    public class MockPreBuilds
    {

        public List<ProductsClass> Products { get; private set; }
        public List<Cases> cases { get; }
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

        public static List<ProductsClass> _prebuild = new List<ProductsClass>()
        {
            //new Cases("Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button" ),
            //new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0),
            //new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105),
            //new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP" ),
            //new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB"),
            //new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
            //new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0),
            //new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv"),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" ),
            //new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" )
        };


        public static List<PreBuildsClass> _prebuilds = new List<PreBuildsClass>()
        {
            new PreBuildsClass("Boob tank", 25999, "do you think i well get som puss if i show her that?", false, "/Images/PreBuilds/PreBuild1.png", "High-end gaming pc to the gamer that wants ultimate performance", "/ProductInfoPages/PreBuildInfoPages/PreBuild1InfoPage",
                new Cases("Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button", "/Images/Components/Case3.png", "This case is specifically designed to make any casual gamer cry.", "/ProductInfoPages/ComponentInfoPages/CasePage3"),
                new Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0, "/Images/Components/Motherboard1.png", "Gigabyte X570S AORUS Master is a that 5400 bus clock and and supports a DDR4 technology.", "/ProductInfoPages/ComponentInfoPages/MotherBoardPage1"),
                new CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105, "/Images/Components/CPU1.png", "Ryzen 9 5950x is a winner and a solid choice for the gamer who wants to build a good and strong computer.", "/ProductInfoPages/ComponentInfoPages/CpuPage1"),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 360 A-RGB COOLER", 999, true, true, "Radiator full for rgp fans", "Copper, Micro-Skived-Fins", true, "1700, 1200, 115X, 2011-3*, 2066* *Square ILM, AM5, AM4", 3, 2.7, 240, "4-pin", "48.8", 2000,"0", "1.85", "NO RGP", "/Images/Components/CPUwater3.png", "If you want your CPU to stay just as chill as yourself, then this is the CPU for you.", "/ProductInfoPages/ComponentInfoPages/CpuWaterCoolingPage3"),
                new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB", "/Images/Components/RAM2.png", "G.SKILL Tridentz RGP 32 gb will give you what you need and they only have a CL 16 in latency timings which makes them even faster.", "/ProductInfoPages/ComponentInfoPages/RamPage2"),
                new GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0, "/Images/Components/GPU1.png", "You know what they say, there's a pot of gold at the end of the rainbow. Well thats a lie theres only this awesome GPU.", "/ProductInfoPages/ComponentInfoPages/GpuPage1"),
                new Mdot2("Samsung 980 PRO 2TB M.2-2280", 2276.92, true, true, "High-end", 2000, "M.2", 7000, 4.0, "/Images/Components/Mdot2-1.png", "Samsung 980 PRO 2TB M.2-2280 with its high performance transfer rate at 7000mb/sec.", "/ProductInfoPages/ComponentInfoPages/Mdot2Page1"),
                new PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv", "/Images/Components/PSU1.png", "Corsair AX1600I Modular Titanium is certified as a Titanium PSU it delivers up to a total 1600W.", "/ProductInfoPages/ComponentInfoPages/PowerSupplyPage1"),
                new CaseFan("be quiet! 120mm Silent Wings 4 Quiet Fan", 159, true, true, "Be quiet is a 9 blade quiet fan","Fluid Dynamic", 1.79, 120, "120", "3-pin", 48.7, "1600", "1.79 m2/h","NO RGB" , "/Images/Components/CaseFan2.png", "If you want your computer to be cold as the siberian winter then this one is the perfect choice for you.", "/ProductInfoPages/ComponentInfoPages/CaseFanPage2")                
                ),

            new PreBuildsClass("Cockharhinus", 17999, "do you think i well get som puss if i show her that?", false, "/Images/PreBuilds/PreBuild2.png", "Mid-end gaming pc to the gamer that wants the best parts for the budget", "/ProductInfoPages/PreBuildInfoPages/PreBuild2InfoPage",
                new Cases("Shark Gaming Aquarium", 999, true, true, "A case with tempered glass", "MidTower (ATX)", "Black", 10, true, 280, 415, 427, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio", "/Images/Components/Case1.png", "Shark gaming aquarium is a case that allows you to connect to the motherboard and control RGB through the software.", "/ProductInfoPages/ComponentInfoPages/CasePage1"),
                new Motherboard("EXDISPLAY MSI X570", 1200.21, true, false, "Low-end", true, 128, "DDR4", 4400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0, "/Images/Components/Motherboard2.png", "EXDISPLAY MSI X570 is a motherboard that uses the AM4 socket which fits AMD processors.", "/ProductInfoPages/ComponentInfoPages/MotherBoardPage2"),
                new CPU("Ryzen 7 5800X", 1858.60, true, false, "Mid-end", 3.8, 4.7, 8, 16, "AM4", true, 4.0, 105, "/Images/Components/CPU2.png", "This CPU will definitely take your computer to the next level.", "/ProductInfoPages/ComponentInfoPages/CpuPage2"),
                new CPUWaterCooling("NZXT KRAKEN X53 CPU KØLER - VANDKØLER", 999, true, true, "Cam control very nice",   "Heatsink: Aluminum", true, "Intel Socket LGA 1200, 1151, 1150, 1155, 1156, 1366, 2011, 2011-3, 2066 , AMD Socket AM4, sTRX4*, TR4*(*Threadripper bracket not included)", 2, 2.7, 240, "4-pin", "48.8", 1800,"0", "1.85", "ONLY PUMP SOCKET RGP", "/Images/Components/CPUwater2.png", "This is no ordinary water cooler. Oh well, it is but it's very cool.", "/ProductInfoPages/ComponentInfoPages/CpuWaterCoolingPage2"),
                new RAM("Corsair Vengeance RGB Black Pro 16GB", 543, true, true, "Mid-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB", "/Images/Components/RAM1.png", "Corsair Vengeance RGB Pro 16GB will also light up your pc with the solid glow sticks on the top.", "/ProductInfoPages/ComponentInfoPages/RamPage1"),
                new GPU("Gigabyte GeForce RTX 3070 TI", 5605.89, true, true, "Mid-end GPU", "NVIDIA GeForce RTX 3070 TI", 6144, true, "7680 x 4320", 8000, "GDDR6X SDRAM", 256, 850, 29.49, 4.0, "/Images/Components/GPU2.png", "Gigabyte GeForce RTX 3070TI is a great card with GDDR6X SDRAM technology and is VR-compatible.", "/ProductInfoPages/ComponentInfoPages/GpuPage2"),
                new Mdot2("Samsung 980 PRO 1TB M.2-2280", 1346.40, true, true, "Mid-end", 1000, "M.2", 7000, 4.0, "/Images/Components/Mdot2-2.png", "Samsung 980 PRO 1TB M.2-2280 amazing m.2 ssd with high transfer and storage.", "/ProductInfoPages/ComponentInfoPages/Mdot2Page2"),
                new PowerSupply("Asus ROG Strix 750 Modular", 1130.61, true, true, "Mid-end", "ATX", "Black", "Gold", 750, true, "Aktive", "/Images/Components/PSU3.png", "The Asus ROG Strix 750 Modular gives you the power of 750W its also modular which means you can use your old plugs if you still have them in your case.", "/ProductInfoPages/ComponentInfoPages/PowerSupplyPage3"),
                new CaseFan("Arctic P12 PWM PST BLACK 120mm Fan", 59, true, true, "Black Airflow Fan which has a low noice level","Fluid Dynamic", 1.44, 120, "120" ,"3-pin", 56.3 , "200-1800", "1.79 m2/h","NO RGB", "/Images/Components/CaseFan1.png", "This casefan is the perfect option to keep your computer just as cool as yourself.", "/ProductInfoPages/ComponentInfoPages/CaseFanPage1")
                ),

            new PreBuildsClass("boll shark", 9999, "do you think i well get som puss if i show her that?", false, "/Images/PreBuilds/PreBuild3.png", "Low-end cumputer for the people that only plays Minecraft", "/ProductInfoPages/PreBuildInfoPages/PreBuild3InfoPage",
                new Cases("Shark Gaming MaelStrom", 599, true, true, "A RGB flow case", "MiniTower (m-ATX)", "Black", 4, true, 210, 405, 425, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio", "/Images/Components/Case2.png", "This case is the perfect choice for the gamer who is a casual but doesn't want to look like one.", "/ProductInfoPages/ComponentInfoPages/CasePage2"),
                new Motherboard("ASRock Z590 Extreme", 1681.73, false, true, "Mid-end", true, 128, "DDR4", 4800, "Motherboard - ATX", "Z590", "LGA 1200", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0, "/Images/Components/Motherboard3.png", "THE ASRock Z590 Extreme is an ATX motherboard that uses the LGA Socket for intels processors.", "/ProductInfoPages/ComponentInfoPages/MotherBoardPage3"),
                new CPU("Intel i5 11400 11th", 1164.72, false, true, "Low-end", 2.6, 4.4, 6, 12, "Socket 1200", false, 4.0, 65, "/Images/Components/CPU3.png", "The CPU of your dreams. With this you will be the new celebrity on your Discord server.", "/ProductInfoPages/ComponentInfoPages/CpuPage3"),
                new CPUWaterCooling("ARCTIC LIQUID FREEZER II 240 CPU KØLER - VANDKØLER", 649, true, true, "OUTSTANDING PERFORMANCE",   "Copper, Micro-Skived-Fins", true, "Intel® LGA2066 / LGA 2011-3 / 2011 / 1366 / 1156 / 1155 / 1151 / 1150 / 775 socket , AMD® AM4 / AM3+ / AM3 / AM2+ / FM2+ / FM2 / FM1 socket", 2, 2.7, 240, "4-pin", "48.8", 1800,"0", "1.85", "NO RGP", "/Images/Components/CPUwater1.png", "This cooler definitely help keep your CPU cold and chill.", "/ProductInfoPages/ComponentInfoPages/CpuWaterCoolingPage1"),
                new RAM("Kingston FURY Beast 16GB", 262.88, true, true, "Low-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 18", 1.35, "RGB", "/Images/Components/RAM3.png", "Kingston FURY Beast 16GB make gives you a better performance with their 3200 mhz speed and DDR4 technology.", "/ProductInfoPages/ComponentInfoPages/RamPage3"),
                new GPU("MSI GeForce RTX 3060 TI Ventus", 3881.03, true, true, "Low-end GPU", "NVIDIA GeForce RTX 3060 TI", 4864, true, "7680 x 4320", 8000, "GDDR6X SDRAM", 256, 600, 21.31, 4.0, "/Images/Components/GPU3.png", "MSI GeForce RTX 3060TI Ventus is a great card for its price. It has 8GB of memory and a max resolution of 7680x4320", "/ProductInfoPages/ComponentInfoPages/GpuPage3"),
                new SolidStateDrive("Samsung 870 QVO 2.5¨ SSD - 1TB", 618, true, true, "Low power DDR4 SDRAM", 1000, "2.5¨", 560, 530, 11000, 35000, "Quad-niveau celle", "/Images/Components/SSD1.png", "Samsungs EVO870 1 TB delivers a transfer up to 560 mb/sec. The SSD helps you with loading windows and will give you a new gaming experience.", "/ProductInfoPages/ComponentInfoPages/SsdPage1"),
                new PowerSupply("NZXT C550", 784.76, true, true, "Low-end", "ATX", "Black", "Bronze", 550, false, "Aktive", "/Images/Components/PSU2.png", "The NZXT C550 Delivers the power of 550W which is the categorized as a bronze certification.", "/ProductInfoPages/ComponentInfoPages/PowerSupplyPage2"),
                new CaseFan("ThermalTake Riing Plus 12 RGB SYNC Edition 3 Pack", 59, true, true, "Patented LED Design","Hydraulic bearing", 2.01, 120 ,"120","3-pin", 56.3 , "1800", "1.79 m2/h","RGB" , "/Images/Components/CaseFan3.png", "This casefan is alright. It's cheap, which is a good factor for some people.", "/ProductInfoPages/ComponentInfoPages/CaseFanPage3")
                )
        };


        public static List<PreBuildsClass> GetMockPreBuilds()
        {
            return _prebuilds;
        }

    }
}
