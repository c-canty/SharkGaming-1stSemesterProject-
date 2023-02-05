using SharkGaming.Order;
using SharkGaming.OrderFile;
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
using SharkGaming.Products.CustomPc;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Users;
using SharkGaming.Users.Customer;
using System.Text.Json;

namespace SharkGaming.Services.JsonServiceFile
{
    public class JsonService
    {

        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        #region Product Json
        private string JsonFileNameProduct
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Products.json"); }
        }

        public void SaveJsonProducts(List<ProductsClass> products)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameProduct))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<ProductsClass[]>(jsonWriter, products.ToArray());
            }
        }

        public IEnumerable<ProductsClass> GetJsonProducts()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameProduct))
            {
                return JsonSerializer.Deserialize<ProductsClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion
        
        #region Components Json
        private string JsonFileNameComponents
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Components.json"); }
        }

        public void SaveJsonComponents(List<ComponentsClass> components)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameComponents))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<ComponentsClass[]>(jsonWriter, components.ToArray());
            }
        }

        public IEnumerable<ComponentsClass> GetJsonComponents()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameComponents))
            {
                return JsonSerializer.Deserialize<ComponentsClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Pre Builds Json
        private string JsonFileNamePreBuilds
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "PreBuilds.json"); }
        }

        public void SaveJsonPreBuilds(List<PreBuildsClass> preBuilds)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNamePreBuilds))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<PreBuildsClass[]>(jsonWriter, preBuilds.ToArray());
            }
        }

        public IEnumerable<PreBuildsClass> GetJsonPreBuilds()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNamePreBuilds))
            {
                return JsonSerializer.Deserialize<PreBuildsClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Custom PCs Json
        private string JsonFileNameCustomPcs
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "CustomPc.json"); }
        }

        public void SaveJsonCustomPcs(List<CustomPcClass> customPcs)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCustomPcs))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CustomPcClass[]>(jsonWriter, customPcs.ToArray());
            }
        }

        public IEnumerable<CustomPcClass> GetJsonCustomPcs()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCustomPcs))
            {
                return JsonSerializer.Deserialize<CustomPcClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Cases Json
        private string JsonFileNameCases
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Cases.json"); }
        }

        public void SaveJsonCases(List<Cases> cases)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCases))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Cases[]>(jsonWriter, cases.ToArray());
            }
        }

        public IEnumerable<Cases> GetJsonCases()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCases))
            {
                return JsonSerializer.Deserialize<Cases[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion
        
        #region Cooling Json
        private string JsonFileNameCooling
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Cooling.json"); }
        }

        public void SaveJsonCooling(List<CoolingClass> cooling)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCooling))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CoolingClass[]>(jsonWriter, cooling.ToArray());
            }
        }

        public IEnumerable<CoolingClass> GetJsonCooling()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCooling))
            {
                return JsonSerializer.Deserialize<CoolingClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Case Fans Json
        private string JsonFileNameCaseFans
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "CaseFans.json"); }
        }

        public void SaveJsonCaseFans(List<CaseFan> caseFan)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCaseFans))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CoolingClass[]>(jsonWriter, caseFan.ToArray());
            }
        }

        public IEnumerable<CaseFan> GetJsonCaseFans()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCaseFans))
            {
                return JsonSerializer.Deserialize<CaseFan[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region CPU Cooling Json
        private string JsonFileNameCPUCooling
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "CPUCooling.json"); }
        }

        public void SaveJsonCPUCooling(List<CPUCooling> cpuCooling)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCPUCooling))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CPUCooling[]>(jsonWriter, cpuCooling.ToArray());
            }
        }

        public IEnumerable<CPUCooling> GetJsonCPUCooling()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCPUCooling))
            {
                return JsonSerializer.Deserialize<CPUCooling[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region CPU Air Cooling Json
        private string JsonFileNameCPUAirCooling
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "CPUAirCooling.json"); }
        }

        public void SaveJsonCPUAirCooling(List<CPUAirCooling> airCooling)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCPUAirCooling))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CPUAirCooling[]>(jsonWriter, airCooling.ToArray());
            }
        }

        public IEnumerable<CPUAirCooling> GetJsonCPUAirCooling()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCPUAirCooling))
            {
                return JsonSerializer.Deserialize<CPUAirCooling[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region CPU Water Cooling Json
        private string JsonFileNameCPUWaterCooling
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "CPUWaterCooling.json"); }
        }

        public void SaveJsonCPUWaterCooling(List<CPUWaterCooling> waterCooling)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCPUWaterCooling))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CPUWaterCooling[]>(jsonWriter, waterCooling.ToArray());
            }
        }

        public IEnumerable<CPUWaterCooling> GetJsonCPUWaterrCooling()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCPUWaterCooling))
            {
                return JsonSerializer.Deserialize<CPUWaterCooling[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region CPU Json
        private string JsonFileNameCPU
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "CPU.json"); }
        }

        public void SaveJsonCPU(List<CPU> cpu)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameCPU))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CPU[]>(jsonWriter, cpu.ToArray());
            }
        }

        public IEnumerable<CPU> GetJsonCPU()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameCPU))
            {
                return JsonSerializer.Deserialize<CPU[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region GPU Json
        private string JsonFileNameGPU
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "GPU.json"); }
        }

        public void SaveJsonGPU(List<GPU> gpu)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameGPU))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<GPU[]>(jsonWriter, gpu.ToArray());
            }
        }

        public IEnumerable<GPU> GetJsonGPU()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameGPU))
            {
                return JsonSerializer.Deserialize<GPU[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion
       
        #region Motherboard Json
        private string JsonFileNameMotherboards
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Motherboards.json"); }
        }

        public void SaveJsonMotherboards(List<Motherboard> motherboards)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameMotherboards))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Motherboard[]>(jsonWriter, motherboards.ToArray());
            }
        }

        public IEnumerable<Motherboard> GetJsonMotherboards()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameMotherboards))
            {
                return JsonSerializer.Deserialize<Motherboard[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Power Supply Json
        private string JsonFileNamePowerSupply
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "PowerSupply.json"); }
        }

        public void SaveJsonPowerSupply(List<PowerSupply> psu)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNamePowerSupply))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<PowerSupply[]>(jsonWriter, psu.ToArray());
            }
        }

        public IEnumerable<PowerSupply> GetJsonPowerSupply()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNamePowerSupply))
            {
                return JsonSerializer.Deserialize<PowerSupply[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Storage Json
        private string JsonFileNameStorage
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Storage.json"); }
        }

        public void SaveJsonStorage(List<StorageClass> storage)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameStorage))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<StorageClass[]>(jsonWriter, storage.ToArray());
            }
        }

        public IEnumerable<StorageClass> GetJsonStorage()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameStorage))
            {
                return JsonSerializer.Deserialize<StorageClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region RAM Json
        private string JsonFileNameRAM
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "RAM.json"); }
        }

        public void SaveJsonRAM(List<RAM> rAMs)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameRAM))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<RAM[]>(jsonWriter, rAMs.ToArray());
            }
        }

        public IEnumerable<RAM> GetJsonRAM()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameRAM))
            {
                return JsonSerializer.Deserialize<RAM[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Mdot2 Json
        private string JsonFileNameMdot2
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Mdot2.json"); }
        }

        public void SaveJsonMdot2(List<Mdot2> mdot2)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameMdot2))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Mdot2[]>(jsonWriter, mdot2.ToArray());
            }
        }

        public IEnumerable<Mdot2> GetJsonMdot2()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameMdot2))
            {
                return JsonSerializer.Deserialize<Mdot2[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion
        
        #region SSD Json
        private string JsonFileNameSSD
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "SSD.json"); }
        }

        public void SaveJsonSSD(List<SolidStateDrive> SSD)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameSSD))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<SolidStateDrive[]>(jsonWriter, SSD.ToArray());
            }
        }

        public IEnumerable<SolidStateDrive> GetJsonSSD()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameSSD))
            {
                return JsonSerializer.Deserialize<SolidStateDrive[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Order Json
        private string JsonFileNameOrder
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Order.json"); }
        }

        public void SaveJsonOrder(List<OrderClass> Order)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameOrder))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<OrderClass[]>(jsonWriter, Order.ToArray());
            }
        }

        public IEnumerable<OrderClass> GetJsonOrder()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameOrder))
            {
                return JsonSerializer.Deserialize<OrderClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region Order Items Json
        private string JsonFileNameOrderItems
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "OrderItems.json"); }
        }

        public void SaveJsonOrderItems(List<OrderItemsClass> OrderItems)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileNameOrderItems))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<OrderItemsClass[]>(jsonWriter, OrderItems.ToArray());
            }
        }

        public IEnumerable<OrderItemsClass> GetJsonOrderItems()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileNameOrderItems))
            {
                return JsonSerializer.Deserialize<OrderItemsClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion

        #region User Json
        private string JsonFileUsers
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Users.json"); }
        }

        public void SaveJsonUser(List<User> user)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileUsers))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<User[]>(jsonWriter, user.ToArray());
            }
        }

        public IEnumerable<User> GetJsonUser()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileUsers))
            {
                return JsonSerializer.Deserialize<User[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion


        #region Customer Json
        private string JsonFileCustomer
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Customers.json"); }
        }

        public void SaveJsonCustomer(List<CustomerClass> customerClasses)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileCustomer))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<CustomerClass[]>(jsonWriter, customerClasses.ToArray());
            }
        }

        public IEnumerable<CustomerClass> GetJsonCustomer()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileUsers))
            {
                return JsonSerializer.Deserialize<CustomerClass[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion
    }
}
