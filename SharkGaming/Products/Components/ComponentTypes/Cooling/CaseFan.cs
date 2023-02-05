namespace SharkGaming.Products.Components.ComponentTypes.Cooling
{
    public class CaseFan : CoolingClass
    {
        public string BearingType { get; set; }


        public CaseFan(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, string bearingType, double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory, string img, string description, string link)
        : base(thermalDesignPower, size, powerConnector, airFlow, rpm, squareMetersPerHour, mmH20, colourCatagory, name, price, amdCompatible, intelCompatible, specInfo, img, description, link)
        {

            BearingType = bearingType;
            Id = nextId++;
            Link = link;
        }

        public CaseFan()
        {

        }
    }
}
