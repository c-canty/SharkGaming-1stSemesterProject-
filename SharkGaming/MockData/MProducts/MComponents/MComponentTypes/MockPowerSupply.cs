namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockPowerSupply
    {

        public static List<SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply> _PowerSupply = new List<SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply>()
        {
            new SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply("Corsair AX1600I Modular Titanium", 4139.77, true, true, "High-end", "ATX", "Black", "Titanium", 1600, true, "Passiv", "/Images/Components/PSU1.png", "Corsair AX1600I Modular Titanium is certified as a Titanium PSU it delivers up to a total 1600W.", "/ProductInfoPages/ComponentInfoPages/PowerSupplyPage1"),
            new SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply("NZXT C550", 784.76, true, true, "Low-end", "ATX", "Black", "Bronze", 550, false, "Aktive", "/Images/Components/PSU2.png", "The NZXT C550 Delivers the power of 550W which is the categorized as a bronze certification.", "/ProductInfoPages/ComponentInfoPages/PowerSupplyPage2"),
            new SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply("Asus ROG Strix 750 Modular", 1130.61, true, true, "Mid-end", "ATX", "Black", "Gold", 750, true, "Aktive", "/Images/Components/PSU3.png", "The Asus ROG Strix 750 Modular gives you the power of 750W its also modular which means you can use your old plugs if you still have them in your case.", "/ProductInfoPages/ComponentInfoPages/PowerSupplyPage3")
        };

        public static List<SharkGaming.Products.Components.ComponentTypes.PowerSupply.PowerSupply> GetMockPowerSupplies() { return _PowerSupply; }


    }
}
