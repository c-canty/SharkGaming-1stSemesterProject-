namespace SharkGaming.Products.Components.ComponentTypes.Cooling
{
    public class CPUCooling : CoolingClass
    {
        public bool Type { get; set; }
        public string Socket { get; set; }
        public int FanAmount { get; set; }

        public CPUCooling()
        {

        }

        public CPUCooling(bool type, string socket, int fanAmount, double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory, string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, string img, string description, string link)
        : base(thermalDesignPower, size, powerConnector, airFlow, rpm, squareMetersPerHour, mmH20, colourCatagory, name, price, amdCompatible, intelCompatible, specInfo, img, description, link)
        {
            Type = type;
            Socket = socket;
            FanAmount = fanAmount;
            
        }
    }
}
