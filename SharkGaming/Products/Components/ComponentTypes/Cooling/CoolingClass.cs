namespace SharkGaming.Products.Components.ComponentTypes.Cooling
{
    public class CoolingClass : ComponentsClass
    {
        public double ThermalDesignPower { get; set; }
        public double Size { get; set; }
        public string PowerConnector { get; set; }
        public string AirFlow { get; set; }
        public double Rpm { get; set; }
        public string SquareMetersPerHour { get; set; }
        public string MmH20 { get; set; }
        public string ColourCatagory { get; set; }
        public bool AMDCompatible { get; set; }
        public bool IntelCompatible { get; set; }

        public CoolingClass()
        {

        }

        public CoolingClass(double thermalDesignPower, double size, string powerConnector, string airFlow, double rpm, string squareMetersPerHour, string mmH20, string colourCatagory, string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, string img, string description, string link)
        : base( name, price, amdCompatible, intelCompatible, specInfo, img, description, link)
        {
            ThermalDesignPower = thermalDesignPower;
            Size = size;
            PowerConnector = powerConnector;
            AirFlow = airFlow;
            Rpm = rpm;
            SquareMetersPerHour = squareMetersPerHour;
            MmH20 = mmH20;
            ColourCatagory = colourCatagory;
            AMDCompatible = amdCompatible;
            IntelCompatible = intelCompatible;
        }
    }
}
