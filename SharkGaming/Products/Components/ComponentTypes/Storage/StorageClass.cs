namespace SharkGaming.Products.Components.ComponentTypes.Storage
{
    public class StorageClass : ComponentsClass
    {
        public int Capacity { get; set; }
        public string CompatibleBay { get; set; }
        public double InternalDateRate { get; set; }

        public StorageClass()
        {

        }

        public StorageClass(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, int capacity, string compatibleBay, double internalDateRate, string img, string description, string link)
            : base(name, price, amdCompatible, intelCompatible, specInfo, img, description, link)
        {
            Capacity = capacity;
            CompatibleBay = compatibleBay;
            InternalDateRate = internalDateRate;
        }
    }
}
