namespace SharkGaming.Products.Components.ComponentTypes.Storage
{
    public class SolidStateDrive : StorageClass
    {
        public double DriveTransferRate { get; set; }
        public double FourKBRandomRead { get; set; }
        public double FourKBRandomWrite { get; set; }
        public string NANDFlashMemoryType { get; set; }

        public SolidStateDrive()
        {

        }

        public SolidStateDrive(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, int capacity, string compatibleBay, double internalDateRate, double driveTransferRate, double fourKBRandomRead, double fourKBRandomWrite, string nandFlashMemoryType, string img, string description, string link)
            : base(name, price, amdCompatible, intelCompatible, specInfo, capacity, compatibleBay, internalDateRate, img, description, link)
        {
            DriveTransferRate = driveTransferRate;
            FourKBRandomRead = fourKBRandomRead;
            FourKBRandomWrite = fourKBRandomWrite;
            NANDFlashMemoryType = nandFlashMemoryType;
            Id = nextId++;
        }
    }
}
