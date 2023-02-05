using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components;
using SharkGaming.Products.CustomPc;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Products;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes;
using SharkGaming.MockData.Products.Components;
using SharkGaming.Services.JsonServiceFile;
using SharkGaming.MockData.Products.PreBuilds;
using System.Text.Json.Nodes;
using SharkGaming.OrderFile;

namespace SharkGaming.Services.ProductServiceFile
{
    public class ProductService : IProductService // All customPc commented out
    {
        #region Lists       
        private List<PreBuildsClass> _preBuilds;
        //private List<CustomPcClass> _customPcs;
        private List<Cases> _cases;
        private List<CaseFan> _caseFans;
        private List<CPUAirCooling> _cPUAirCooling;
        private List<CPUWaterCooling> _cPUWaterCooling;
        private List<CPU> _cPUs;
        private List<GPU> _gPUs;
        private List<Motherboard> _motherboards;
        private List<PowerSupply> _powerSupplies;
        private List<RAM> _rAMs;
        private List<Mdot2> _mdot2s;
        private List<SolidStateDrive> _solidStateDrives;
        #endregion

        #region initialise Lists
        public ProductService()
        {

            _preBuilds = MockPreBuilds.GetMockPreBuilds();
            //_customPcs = MockCustomPC.GetMockCustomPcs();
            _cases = MockCaseS.GetMockCases();            
            _caseFans = MockCaseFan.GetMockCaseFans();
            _cPUAirCooling = MockCPUAirCooling.GetMockCPUAirCoolings();
            _cPUWaterCooling = MockCPUWaterCooling.GetMockCPUWaterCooling();
            _cPUs = MockCPU.GetMockCPUs();
            _gPUs = MockGPU.GetMockGPUs();
            _motherboards = MockMotherboard.GetMockMotherboards();
            _powerSupplies = MockPowerSupply.GetMockPowerSupplies();            
            _rAMs = MockRam.GetMockRam();
            _mdot2s = MockMdot.GetMockMdot2s();
            _solidStateDrives = MockSolidStateDrive.GetMockSoildSateDrives();
        }
        #endregion

        #region Get methods       
        public List<PreBuildsClass> GetPreBuilds()
        {
            return _preBuilds;
        }
        //public List<CustomPcClass> GetCustomPc()
        //{
        //    return _customPcs;
        //}
        public List<Cases> GetCases()
        {
            return _cases;
        }      
        public List<CaseFan> GetCaseFan()
        {
            return _caseFans;
        }       
        public List<CPUAirCooling> GetCPUAirCooling()
        {
            return _cPUAirCooling;
        }
        public List<CPUWaterCooling> GetCPUWaterCooling()
        {
            return _cPUWaterCooling;
        }
        public List<CPU> GetCPUs()
        {
            return _cPUs;
        }
        public List<GPU> GetGPUs()
        {
            return _gPUs;
        }
        public List<Motherboard> GetMotherboards()
        {
            return _motherboards;
        }
        public List<PowerSupply> GetPowerSupply()
        {
            return _powerSupplies;
        }
        public List<RAM> GetRAM()
        {
            return _rAMs;
        }
        public List<Mdot2> GetMdot2()
        {
            return _mdot2s;
        }
        public List<SolidStateDrive> GetSolidStateDrives()
        {
            return _solidStateDrives;
        }
        #endregion

        #region Add to list methods
        public void AddPreBuild(PreBuildsClass preBuilds)
        {
            _preBuilds.Add(preBuilds);
            JsonService.SaveJsonPreBuilds(_preBuilds);  
        }
        //public void AddCustomPc(CustomPcClass customPc)
        //{
        //    _customPcs.Add(customPc);
        //    JsonService.SaveJsonCustomPcs(_customPcs);   
        //}
        public void AddCase(Cases cas)
        {
            _cases.Add(cas);
            JsonService.SaveJsonCases(_cases);
        }       
        public void AddCaseFan(CaseFan caseFan)
        {
            _caseFans.Add(caseFan);
            JsonService.SaveJsonCaseFans(_caseFans);
        }
        public void AddCPUAirCooling(CPUAirCooling air)
        {
            _cPUAirCooling.Add(air);
            JsonService.SaveJsonCPUAirCooling(_cPUAirCooling);
        }
        public void AddCPUWaterCooling(CPUWaterCooling water)
        {
            _cPUWaterCooling.Add(water);
            JsonService.SaveJsonCPUWaterCooling(_cPUWaterCooling);
        }
        public void AddCPU(CPU cpu)
        {
            _cPUs.Add(cpu);
            JsonService.SaveJsonCPU(_cPUs);
        }
        public void AddGPU(GPU gpu)
        {
            _gPUs.Add(gpu);
            JsonService.SaveJsonGPU(_gPUs);
        }
        public void AddMotherboard(Motherboard motherboard)
        {
            _motherboards.Add(motherboard);
            JsonService.SaveJsonMotherboards(_motherboards);
        }
        public void AddPowerSupply(PowerSupply psu)
        {
            _powerSupplies.Add(psu);
            JsonService.SaveJsonPowerSupply(_powerSupplies);
        }
        public void AddRAM(RAM ram)
        {
            _rAMs.Add(ram);           
            JsonService.SaveJsonRAM(_rAMs);
        }
        public void AddMdot2(Mdot2 mdot2)
        {
            _mdot2s.Add(mdot2);
            JsonService.SaveJsonMdot2(_mdot2s);
        }
        public void AddSolidStateDrive(SolidStateDrive ssd)
        {
            _solidStateDrives.Add(ssd);
            JsonService.SaveJsonSSD(_solidStateDrives);
        }

        #endregion

        #region json
        private JsonService JsonService { get; set; }

        public ProductService(JsonService jsonService)
        {
            JsonService = jsonService;
            //_preBuilds = MockPreBuilds.GetMockPreBuilds().ToList();
            ////_customPcs = MockCustomPC.GetMockCustomPcs().ToList();
            //_cases = MockCaseS.GetMockCases().ToList();
            //_caseFans = MockCaseFan.GetMockCaseFans().ToList();
            //_cPUAirCooling = MockCPUAirCooling.GetMockCPUAirCoolings().ToList();
            //_cPUWaterCooling = MockCPUWaterCooling.GetMockCPUWaterCooling().ToList();
            //_cPUs = MockCPU.GetMockCPUs().ToList();
            //_gPUs = MockGPU.GetMockGPUs().ToList();
            //_motherboards = MockMotherboard.GetMockMotherboards().ToList();
            //_powerSupplies = MockPowerSupply.GetMockPowerSupplies().ToList();
            //_rAMs = MockRam.GetMockRam().ToList();
            //_mdot2s = MockMdot.GetMockMdot2s().ToList();
            //_solidStateDrives = MockSolidStateDrive.GetMockSoildSateDrives().ToList();

            _preBuilds = JsonService.GetJsonPreBuilds().ToList();
            _cases = JsonService.GetJsonCases().ToList();
            _caseFans = JsonService.GetJsonCaseFans().ToList();
            _cPUAirCooling = JsonService.GetJsonCPUAirCooling().ToList();
            _cPUWaterCooling = JsonService.GetJsonCPUWaterrCooling().ToList();
            _cPUs = JsonService.GetJsonCPU().ToList();
            _gPUs = JsonService.GetJsonGPU().ToList();
            _motherboards = JsonService.GetJsonMotherboards().ToList();
            _powerSupplies = JsonService.GetJsonPowerSupply().ToList();
            _rAMs = JsonService.GetJsonRAM().ToList();
            _mdot2s = JsonService.GetJsonMdot2().ToList();
            _solidStateDrives = JsonService.GetJsonSSD().ToList();
        }
        #endregion

        #region Name Search
        public IEnumerable<ProductsClass> ProductNameSearch(string str)
        {
            List<ProductsClass> nameSearch = new List<ProductsClass>();
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    
                    //foreach (CustomPcClass item in _customPcs)
                    //{
                    //    if (item.Name.ToLower().Contains(str.ToLower()))
                    //    {
                    //        nameSearch.Add(item);
                    //    }
                    //}

                    foreach (ProductsClass item in _cases)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if(str.ToLower() == "case" || str.ToLower() == "cases" || str.ToLower() == "all")
                    {
                        foreach (ProductsClass prod in _cases)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _caseFans)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "casefan" || str.ToLower() == "case fan" || str.ToLower() == "case fans" || str.ToLower() == "all" || str.ToLower() == "fan" || str.ToLower() == "fans" || str.ToLower() == "case cooling" || str.ToLower() == "cooling") 
                    {
                        foreach (ProductsClass prod in _caseFans)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _cPUAirCooling)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "cpucooling" || str.ToLower() == "cpufan" || str.ToLower() == "all" || str.ToLower() == "cpufans" || str.ToLower() == "fan" || str.ToLower() == "fans" || str.ToLower() == "cpu cooling" || str.ToLower() == "cooling" || str.ToLower() == "cpu fan" || str.ToLower() == "cpu fans")
                    {
                        foreach (ProductsClass prod in _cPUAirCooling)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _cPUWaterCooling)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "cpucooling" || str.ToLower() == "cpufan" || str.ToLower() == "all" || str.ToLower() == "cpufans" || str.ToLower() == "fan" || str.ToLower() == "fans" || str.ToLower() == "cpu cooling" || str.ToLower() == "cooling" || str.ToLower() == "cpu fan" || str.ToLower() == "cpu fans" || str.ToLower() == "watercooling" || str.ToLower() == "watercooled" || str.ToLower() == "water cooling" || str.ToLower() == "water cooled" || str.ToLower() == "liquidcooling" || str.ToLower() == "liquidcooled" || str.ToLower() == "liquid cooling" || str.ToLower() == "liquid cooled" || str.ToLower() == "liquid")
                    {
                        foreach (ProductsClass prod in _cPUWaterCooling)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _cPUs)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "cpu" || str.ToLower() == "central processing unit" || str.ToLower() == "centralprocessingunit" || str.ToLower() == "all")
                    {
                        foreach (ProductsClass prod in _cPUs)
                        {
                            if (!nameSearch.Contains(prod))

                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _gPUs)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "gpu" || str.ToLower() == "graphics processing unit" || str.ToLower() == "all" || str.ToLower() == "graphicsprocessingunit" || str.ToLower() == "graphics card" || str.ToLower() == "graphicscard" || str.ToLower() == "graphics" || str.ToLower() == "graphic" || str.ToLower() == "card")
                    {
                        foreach (ProductsClass prod in _gPUs)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _motherboards)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "motherboard" || str.ToLower() == "mother board" || str.ToLower() == "all")
                    {
                        foreach (ProductsClass prod in _motherboards)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _powerSupplies)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "psu" || str.ToLower() == "powersupply" || str.ToLower() == "all" || str.ToLower() == "power supply" || str.ToLower() == "powersupplies" || str.ToLower() == "power supplies" || str.ToLower() == "power" || str.ToLower() == "supply" || str.ToLower() == "supplies")
                    {
                        foreach (ProductsClass prod in _powerSupplies)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _rAMs)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "ram" || str.ToLower() == "randomaccessmemory" || str.ToLower() == "all" || str.ToLower() == "random access memory" || str.ToLower() == "memory")
                    {
                        foreach (ProductsClass prod in _rAMs)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _mdot2s)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "storage" || str.ToLower() == "m.2" || str.ToLower() == "mdot2" || str.ToLower() == "all")
                    {
                        foreach (ProductsClass prod in _mdot2s)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }

                    foreach (ProductsClass item in _solidStateDrives)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }
                    }
                    if (str.ToLower() == "storage" || str.ToLower() == "ssd" || str.ToLower() == "all" || str.ToLower() == "solidstatedrive" || str.ToLower() == "solid state drive" || str.ToLower() == "solid state" || str.ToLower() == "solid")
                    {
                        foreach (ProductsClass prod in _solidStateDrives)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }
                    foreach (ProductsClass item in _preBuilds)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            if (!nameSearch.Contains(item))
                                nameSearch.Add(item);
                        }

                    }
                    if (str.ToLower() == "prebuild" || str.ToLower() == "pre build" || str.ToLower() == "prebuilds" || str.ToLower() == "pre builds" || str.ToLower() == "all")
                    {
                        foreach (ProductsClass prod in _preBuilds)
                        {
                            if (!nameSearch.Contains(prod))
                                nameSearch.Add(prod);
                        }
                    }
                }
                return nameSearch;
            }
        }
        #endregion

        #region update methods
        public void UpdatePreBuilds(PreBuildsClass preBuildsClass)
        {
            if (preBuildsClass != null)
            {
                foreach (PreBuildsClass i in _preBuilds)
                {
                    if (i.Id == preBuildsClass.Id)
                    {
                        i.Name = preBuildsClass.Name;
                        i.Price = preBuildsClass.Price;
                    }
                }
                JsonService.SaveJsonPreBuilds(_preBuilds);
            }
        }

        //public void UpdateCustomPc(CustomPcClass customPcClass)
        //{
        //    if (CustomPcClass != null)
        //    {
        //        foreach (CustomPcClass i in _customPcs)
        //        {
        //            if (i.Id == customPcClass.Id)
        //            {
        //                i.Name = customPcClass.Name;
        //                i.Price = customPcClass.Price;
        //            }
        //        }
        //        JsonService.SaveJsonCustomPcs(_customPcs);
        //    }
        //}

        public void UpdateCase(Cases cases)
        {
            if (cases != null)
            {
                foreach (Cases i in _cases)
                {
                    if (i.Id == cases.Id)
                    {
                        i.Name = cases.Name;
                        i.Price = cases.Price;
                    }
                }
                JsonService.SaveJsonCases(_cases);
            }
        }

        public void UpdateCaseFan(CaseFan caseFan)
        {
            if (caseFan != null)
            {
                foreach (CaseFan i in _caseFans)
                {
                    if (i.Id == caseFan.Id)
                    {
                        i.Name = caseFan.Name;
                        i.Price = caseFan.Price;
                    }
                }
                JsonService.SaveJsonCaseFans(_caseFans);
            }
        }

        public void UpdateCPUAirCooling(CPUAirCooling cpuAirCooling)
        {
            if (cpuAirCooling != null)
            {
                foreach (CPUAirCooling i in _cPUAirCooling)
                {
                    if (i.Id == cpuAirCooling.Id)
                    {
                        i.Name = cpuAirCooling.Name;
                        i.Price = cpuAirCooling.Price;
                    }
                }
                JsonService.SaveJsonCPUAirCooling(_cPUAirCooling);
            }
        }

        public void UpdateCPUWaterCooling(CPUWaterCooling cpuWaterCooling)
        {
            if (cpuWaterCooling != null)
            {
                foreach (CPUWaterCooling i in _cPUWaterCooling)
                {
                    if (i.Id == cpuWaterCooling.Id)
                    {
                        i.Name = cpuWaterCooling.Name;
                        i.Price = cpuWaterCooling.Price;
                    }
                }
                JsonService.SaveJsonCPUWaterCooling(_cPUWaterCooling);
            }
        }

        public void UpdateCPU(CPU cpu)
        {
            if (cpu != null)
            {
                foreach (CPU i in _cPUs)
                {
                    if (i.Id == cpu.Id)
                    {
                        i.Name = cpu.Name;
                        i.Price = cpu.Price;
                    }
                }
                JsonService.SaveJsonCPU(_cPUs);
            }
        }

        public void UpdateGPU(GPU gpu)
        {
            if (gpu != null)
            {
                foreach (GPU i in _gPUs)
                {
                    if (i.Id == gpu.Id)
                    {
                        i.Name = gpu.Name;
                        i.Price = gpu.Price;
                    }
                }
                JsonService.SaveJsonGPU(_gPUs);
            }
        }

        public void UpdateMotherboards(Motherboard motherboard)
        {
            if (motherboard != null)
            {
                foreach (Motherboard i in _motherboards)
                {
                    if (i.Id == motherboard.Id)
                    {
                        i.Name = motherboard.Name;
                        i.Price = motherboard.Price;
                    }
                }
                JsonService.SaveJsonMotherboards(_motherboards);
            }
        }

        public void UpdatePowerSupply(PowerSupply powerSupply)
        {
            if (powerSupply != null)
            {
                foreach (PowerSupply i in _powerSupplies)
                {
                    if (i.Id == powerSupply.Id)
                    {
                        i.Name = powerSupply.Name;
                        i.Price = powerSupply.Price;
                    }
                }
                JsonService.SaveJsonPowerSupply(_powerSupplies);
            }
        }

        public void UpdateMdot2(Mdot2 mdot2)
        {
            if (mdot2 != null)
            {
                foreach (Mdot2 i in _mdot2s)
                {
                    if (i.Id == mdot2.Id)
                    {
                        i.Name = mdot2.Name;
                        i.Price = mdot2.Price;
                    }
                }
                JsonService.SaveJsonMdot2(_mdot2s);
            }
        }

        public void UpdateRAM(RAM ram)
        {
            if (ram != null)
            {
                foreach (RAM i in _rAMs)
                {
                    if (i.Id == ram.Id)
                    {
                        i.Name = ram.Name;
                        i.Price = ram.Price;
                    }
                }
                JsonService.SaveJsonRAM(_rAMs);
            }
        }

        public void UpdateSSD(SolidStateDrive solidStateDrive)
        {
            if (solidStateDrive != null)
            {
                foreach (SolidStateDrive i in _solidStateDrives)
                {
                    if (i.Id == solidStateDrive.Id)
                    {
                        i.Name = solidStateDrive.Name;
                        i.Price = solidStateDrive.Price;
                    }
                }
                JsonService.SaveJsonSSD(_solidStateDrives);
            }
        }
        #endregion

        #region price filter 
        public IEnumerable<ProductsClass> PriceFilter(double maxPrice, double minPrice = 0)
        {
            List<ProductsClass> filterList = new List<ProductsClass>();
            foreach (ProductsClass item in _preBuilds)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }
            
            foreach (ProductsClass item in _cases)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _caseFans)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _cPUAirCooling)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _cPUWaterCooling)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _cPUs)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _gPUs)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _motherboards)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _powerSupplies)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _rAMs)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _mdot2s)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _solidStateDrives)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            return filterList;
        }
        #endregion

        #region Get Product via ID
        public PreBuildsClass GetPreBuildss(int id)
        {
            if (id != null)
            {
                foreach (PreBuildsClass i in _preBuilds)
                    if (i.Id == id)
                    {
                        return i;
                    }
            }
            return null;
        }

        //        public CustomPcClass GetCustomPcs(int id)
        //        {
        //            if (id != null)
        //            {
        //                foreach (CustomPcClass i in _customPcs)
        //                {
        //                    if (i.Id == id)
        //                    {
        //                        return i;
        //                    }
        //}
        //            }
        //            return null;
        //        }

        public Cases GetCases(int id)
        {
            if (id != null)
            {
                foreach (Cases i in _cases)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public CaseFan GetCaseFans(int id)
        {
            if (id != null)
            {
                foreach (CaseFan i in _caseFans)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public CPUAirCooling GetCPUAirCoolings(int id)
        {
            if (id != null)
            {
                foreach (CPUAirCooling i in _cPUAirCooling)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public CPUWaterCooling GetCPUWaterCoolings(int id)
        {
            if (id != null)
            {
                foreach (CPUWaterCooling i in _cPUWaterCooling)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public CPU GetCPUs(int id)
        {
            if (id != null)
            {
                foreach (CPU i in _cPUs)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public GPU GetGPUs(int id)
        {
            if (id != null)
            {
                foreach (GPU i in _gPUs)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public Motherboard GetMotherboards(int id)
        {
            if (id != null)
            {
                foreach (Motherboard i in _motherboards)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public PowerSupply GetPowerSupplys(int id)
        {
            if (id != null)
            {
                foreach (PowerSupply i in _powerSupplies)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public Mdot2 GetMdot2s(int id)
        {
            if (id != null)
            {
                foreach (Mdot2 i in _mdot2s)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public SolidStateDrive GetSolidStateDrives(int id)
        {
            if (id != null)
            {
                foreach (SolidStateDrive i in _solidStateDrives)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public RAM GetRAMs(int id)
        {
            if (id != null)
            {
                foreach (RAM i in _rAMs)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }
        #endregion

        #region delete methods
        public PreBuildsClass DeletePreBuilds(int? itemId)
        {
            PreBuildsClass deletedPreBuilds = null;

            #region Delete Pre Build
            PreBuildsClass preBuildToBeDeleted = null;
            foreach (PreBuildsClass item in _preBuilds)
            {
                if (item.Id != itemId)
                {
                    preBuildToBeDeleted = item;
                    break;
                }
                preBuildToBeDeleted = item;
                break;
            }
            if (preBuildToBeDeleted != null)
            {
                _preBuilds.Remove(preBuildToBeDeleted);
                JsonService.SaveJsonPreBuilds(_preBuilds);
                deletedPreBuilds = preBuildToBeDeleted;
            }
            #endregion
  
            return deletedPreBuilds;
        }

        //public CustomPcClass DeleteCustomPc(int? itemId)
        //{
        //    CustomPcClass deletedCustomPcClass = null;

        //    #region Delete Pre Build
        //    CustomPcClass customPcToBeDeleted = null;
        //    foreach (CustomPcClass item in _customPcs)
        //    {
        //        if (item.Id == itemId)
        //        {
        //            customPcToBeDeleted = item;
        //            break;
        //        }
        //    }
        //    if (customPcToBeDeleted != null)
        //    {
        //        _preBuilds.Remove(customPcToBeDeleted);
        //        JsonService.SaveJsonPreBuilds(_preBuilds);
        //        deletedCustomPcClass = customPcToBeDeleted;
        //    }
        //    #endregion

        //    return deletedCustomPcClass;
        //}

        public Cases DeleteCase(int? itemId)
        {
            Cases deletedCase = null;

            #region Delete Case
            Cases caseToBeDeleted = null;
            foreach (Cases item in _cases)
            {
                if (item.Id != itemId)
                {
                    caseToBeDeleted = item;
                    break;
                }
                caseToBeDeleted = item;
                break;
            }
            if (caseToBeDeleted != null)
            {
                _cases.Remove(caseToBeDeleted);
                JsonService.SaveJsonCases(_cases);
                deletedCase = caseToBeDeleted;
            }
            #endregion

            return deletedCase;
        }

        public CaseFan DeleteCaseFan(int? itemId)
        {
            CaseFan deletedCaseFan = null;

            #region Delete CaseFan
            CaseFan caseFanToBeDeleted = null;
            foreach (CaseFan item in _caseFans)
            {
                if (item.Id != itemId)
                {
                    caseFanToBeDeleted = item;
                    break;
                }
                caseFanToBeDeleted = item;
                break;
            }
            if (caseFanToBeDeleted != null)
            {
                _caseFans.Remove(caseFanToBeDeleted);
                JsonService.SaveJsonCaseFans(_caseFans);
                deletedCaseFan = caseFanToBeDeleted;
            }
            #endregion

            return deletedCaseFan;
        }

        public CPUAirCooling DeleteCPUAirCooling(int? itemId)
        {
            CPUAirCooling deletedAirCooling = null;       

            #region Delete CPU Air Cooling
            CPUAirCooling cPUAirToBeDeleted = null;
            foreach (CPUAirCooling item in _cPUAirCooling)
            {
                if (item.Id != itemId)
                {
                    cPUAirToBeDeleted = item;
                    break;
                }
                cPUAirToBeDeleted = item;
                break;
            }
            if (cPUAirToBeDeleted != null)
            {
                _cPUAirCooling.Remove(cPUAirToBeDeleted);
                JsonService.SaveJsonCPUAirCooling(_cPUAirCooling);
                deletedAirCooling = cPUAirToBeDeleted;
            }
            #endregion 

            return deletedAirCooling;
        }

        public CPUWaterCooling DeleteCPUWaterCooling(int? itemId)
        {
            CPUWaterCooling deletedWaterCooling = null;
        
            #region Delete CPU Water Cooling
            CPUWaterCooling cPUWaterToBeDeleted = null;
            foreach (CPUWaterCooling item in _cPUWaterCooling)
            {
                if (item.Id != itemId)
                {
                    cPUWaterToBeDeleted = item;
                    break;
                }
                cPUWaterToBeDeleted = item;
                break;
            }
            if (cPUWaterToBeDeleted != null)
            {
                _cPUWaterCooling.Remove(cPUWaterToBeDeleted);
                JsonService.SaveJsonCPUWaterCooling(_cPUWaterCooling);
                deletedWaterCooling = cPUWaterToBeDeleted;
            }
            #endregion

            return deletedWaterCooling;
        }

        public CPU DeleteCPU(int? itemId)
        {
            CPU deletedCPU = null;
           
            #region Delete CPU 
            CPU cPUToBeDeleted = null;
            foreach (CPU item in _cPUs)
            {
                if (item.Id != itemId)
                {
                    cPUToBeDeleted = item;
                    break;
                }
                cPUToBeDeleted = item;
                break;
            }
            if (cPUToBeDeleted != null)
            {
                _cPUs.Remove(cPUToBeDeleted);
                JsonService.SaveJsonCPU(_cPUs);
                deletedCPU = cPUToBeDeleted;
            }
            #endregion
        
            return deletedCPU;
        }

        public GPU DeleteGPU(int? itemId)
        {
            GPU deletedGPU = null;
        
            #region Delete GPU 
            GPU gPUToBeDeleted = null;
            foreach (GPU item in _gPUs)
            {
                if (item.Id != itemId)
                {
                    gPUToBeDeleted = item;
                    break;
                }
                gPUToBeDeleted = item;
                break;
            }
            if (gPUToBeDeleted != null)
            {
                _gPUs.Remove(gPUToBeDeleted);
                JsonService.SaveJsonGPU(_gPUs);
                deletedGPU = gPUToBeDeleted;
            }
            #endregion

            return deletedGPU;
        }

        public Motherboard DeleteMotherboard(int? itemId)
        {
            Motherboard deletedMotherboard = null;
         
            #region Delete Motherboard 
            Motherboard motherboardToBeDeleted = null;
            foreach (Motherboard item in _motherboards)
            {
                if (item.Id != itemId)
                {
                    motherboardToBeDeleted = item;
                    break;
                }
                motherboardToBeDeleted = item;
                break;
            }
            if (motherboardToBeDeleted != null)
            {
                _motherboards.Remove(motherboardToBeDeleted);
                JsonService.SaveJsonMotherboards(_motherboards);
                deletedMotherboard = motherboardToBeDeleted;
            }
            #endregion       

            return deletedMotherboard;
        }

        public PowerSupply DeletePowerSupply(int? itemId)
        {
            PowerSupply deletedPowerSupply = null;
         
            #region Delete PSU 
            PowerSupply powerSuppliesToBeDeleted = null;
            foreach (PowerSupply item in _powerSupplies)
            {
                if (item.Id != itemId)
                {
                    powerSuppliesToBeDeleted = item;
                    break;
                }
                powerSuppliesToBeDeleted = item;
                break;
            }
            if (powerSuppliesToBeDeleted != null)
            {
                _powerSupplies.Remove(powerSuppliesToBeDeleted);
                JsonService.SaveJsonPowerSupply(_powerSupplies);
                deletedPowerSupply = powerSuppliesToBeDeleted;
            }
            #endregion
        
            return deletedPowerSupply;
        }

        public RAM DeleteRAM(int? itemId)
        {
            RAM deletedRAM = null;

           
            
            RAM ramToBeDeleted = null;
            foreach (RAM item in _rAMs)
            {
                if (item.Id != itemId)
                {
                    ramToBeDeleted = item;
                    break;
                }
                ramToBeDeleted = item;
                break;
            }
            if (ramToBeDeleted != null)
            {
                _rAMs.Remove(ramToBeDeleted);
                JsonService.SaveJsonRAM(_rAMs);
                deletedRAM = ramToBeDeleted;
            }
            

            return deletedRAM;
        }

        public Mdot2 DeleteMdot2(int? itemId)
        {
            Mdot2 deletedMdot2 = null;
           
            #region Delete M.2
            Mdot2 mdot2ToBeDeleted = null;
            foreach (Mdot2 item in _mdot2s)
            {
                if (item.Id != itemId)
                {
                    mdot2ToBeDeleted = item;
                    break;
                }
                mdot2ToBeDeleted = item;
                break;
            }
            if (mdot2ToBeDeleted != null)
            {
                _mdot2s.Remove(mdot2ToBeDeleted);
                JsonService.SaveJsonMdot2(_mdot2s);
                deletedMdot2 = mdot2ToBeDeleted;
            }
            #endregion

            return deletedMdot2;
        }

        public SolidStateDrive DeleteSSD(int? itemId)
        {
            SolidStateDrive deletedSolidStateDrive = null;

            #region Delete SSD
            SolidStateDrive SSDToBeDeleted = null;
            foreach (SolidStateDrive item in _solidStateDrives)
            {
                if (item.Id != itemId)
                {
                    SSDToBeDeleted = item;
                    break;
                }
                SSDToBeDeleted = item;
                break;
            }
            if (SSDToBeDeleted != null)
            {
                _solidStateDrives.Remove(SSDToBeDeleted);
                JsonService.SaveJsonSSD(_solidStateDrives);
                deletedSolidStateDrive = SSDToBeDeleted;
            }
            #endregion

            return deletedSolidStateDrive;
        }
        #endregion

        #region Calculation methods

        public double preBuildsCalculation(PreBuildsClass preBuildsClass)
        {
            double price = 0;
            //foreach (PreBuildsClass item in preBuildsClass)
            //{
            //    price += item.Price;
            //}
            //if (preBuildsClass.Discount == true)
            //{
            //    price += -1000;
            //}
            return price;
        }

        #endregion

        public List<ProductsClass> ProductList()
        {
            List<ProductsClass> idSearch = new List<ProductsClass>();
            {
                
                {
                    foreach (ProductsClass item in _cases)
                    {
                        
                     idSearch.Add(item);
                        
                    }
            

                    foreach (ProductsClass item in _caseFans)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _cPUAirCooling)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _cPUWaterCooling)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _cPUs)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _gPUs)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _motherboards)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _powerSupplies)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _rAMs)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _mdot2s)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _solidStateDrives)
                    {

                        idSearch.Add(item);

                    }


                    foreach (ProductsClass item in _preBuilds)
                    {

                        idSearch.Add(item);

                    }

                }
                return idSearch;
            }
        }

    }
}
