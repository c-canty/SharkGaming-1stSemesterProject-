using SharkGaming.Products.Components.ComponentTypes.RAM;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockRam
    {

        public static List<RAM> _RAM = new List<RAM>()
        {
            new RAM("Corsair Vengeance RGB Black Pro 16GB", 543, true, true, "Mid-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB", "/Images/Components/RAM1.png", "Corsair Vengeance RGB Pro 16GB will also light up your pc with the solid glow sticks on the top.", "/ProductInfoPages/ComponentInfoPages/RamPage1"),
            new RAM("G.SKILL TridentZ RGB Series 32GB", 1177, true, true, "High-end ram", 32, "DDR4", "DIMM 288-pin", 3200, "CL 16", 1.35, "RGB", "/Images/Components/RAM2.png", "G.SKILL Tridentz RGP 32 gb will give you what you need and they only have a CL 16 in latency timings which makes them even faster.", "/ProductInfoPages/ComponentInfoPages/RamPage2"),
            new RAM("Kingston FURY Beast 16GB", 262.88, true, true, "Low-end ram", 16, "DDR4", "DIMM 288-pin", 3200, "CL 18", 1.35, "RGB", "/Images/Components/RAM3.png", "Kingston FURY Beast 16GB make gives you a better performance with their 3200 mhz speed and DDR4 technology.", "/ProductInfoPages/ComponentInfoPages/RamPage3")

        };

        public static List<RAM> GetMockRam() { return _RAM; }
    }
}
