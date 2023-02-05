namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockCPU
    {
        public static List<SharkGaming.Products.Components.ComponentTypes.CPU.CPU> _CPU = new List<SharkGaming.Products.Components.ComponentTypes.CPU.CPU>
        {
            new SharkGaming.Products.Components.ComponentTypes.CPU.CPU("Ryzen 9 5950X", 4657.26, true, false, "High-end", 3.4, 4.9, 16, 32, "AM4", true, 4.0, 105, "/Images/Components/CPU11.png", "Ryzen 9 5950x is a winner and a solid choice for the gamer who wants to build a good and strong computer.", "/ProductInfoPages/ComponentInfoPages/CpuPage1"),
            new SharkGaming.Products.Components.ComponentTypes.CPU.CPU("Ryzen 7 5800X", 1858.60, true, false, "Mid-end", 3.8, 4.7, 8, 16, "AM4", true, 4.0, 105, "/Images/Components/CPU22.png", "This CPU will definitely take your computer to the next level.", "/ProductInfoPages/ComponentInfoPages/CpuPage2"),
            new SharkGaming.Products.Components.ComponentTypes.CPU.CPU("Intel i5 11400 11th", 1164.72, false, true, "Low-end", 2.6, 4.4, 6, 12, "Socket 1200", false, 4.0, 65, "/Images/Components/CPU33.png", "The CPU of your dreams. With this you will be the new celebrity on your Discord server.", "/ProductInfoPages/ComponentInfoPages/CpuPage3")
        };

        public static List<SharkGaming.Products.Components.ComponentTypes.CPU.CPU> GetMockCPUs()
        {
            return _CPU;
        }
    }
}
