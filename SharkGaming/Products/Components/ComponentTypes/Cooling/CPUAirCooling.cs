namespace SharkGaming.Products.Components.ComponentTypes.Cooling
{
    public class CPUAirCooling : CPUCooling
    {
        public string TowerMaterial { get; set; }

        public CPUAirCooling()
        {

        }

        public CPUAirCooling(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, string towerMaterial, bool type, string socket, int fanAmount, double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory, string img, string description, string link)
            : base(type, socket, fanAmount, thermalDesignPower, size, powerConnector, airFlow, rpm, squareMetersPerHour, mmH20, colourCatagory, name, price, amdCompatible, intelCompatible, specInfo, img, description, link)
        {
            TowerMaterial = towerMaterial;
            Id = nextId++;
        }
    }
}
