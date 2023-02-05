namespace SharkGaming.Products.Components.ComponentTypes.Cooling
{
    public class CPUWaterCooling : CPUCooling
    {
        public string RadiatorMaterial { get; set; }

        public CPUWaterCooling(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, string radiatorMaterial, bool type, string socket, int fanAmount, double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory, string img, string description, string link)
        : base(type, socket, fanAmount, thermalDesignPower, size, powerConnector, airFlow, rpm, squareMetersPerHour, mmH20, colourCatagory, name, price, amdCompatible, intelCompatible, specInfo, img, description, link)
        {
            RadiatorMaterial = radiatorMaterial;
            Id = nextId++;
        }

        public CPUWaterCooling()
        {

        }
    }
}
