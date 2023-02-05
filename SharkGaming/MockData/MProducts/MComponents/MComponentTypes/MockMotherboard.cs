namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockMotherboard
    {
        public static List<SharkGaming.Products.Components.ComponentTypes.Motherboard.Motherboard> _Motherboard = new List<SharkGaming.Products.Components.ComponentTypes.Motherboard.Motherboard>
        {
            new SharkGaming.Products.Components.ComponentTypes.Motherboard.Motherboard("Gigabyte X570S AORUS Master", 2932.32, true, false, "High-end", true, 128, "DDR4", 5400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0, "/Images/Components/Motherboard1.png", "Gigabyte X570S AORUS Master is a that 5400 bus clock and and supports a DDR4 technology.", "/ProductInfoPages/ComponentInfoPages/MotherBoardPage1"),
            new SharkGaming.Products.Components.ComponentTypes.Motherboard.Motherboard("EXDISPLAY MSI X570", 1200.21, true, false, "Low-end", true, 128, "DDR4", 4400, "Motherboard - ATX", "AMD X570", "AM4", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0, "/Images/Components/Motherboard2.png", "EXDISPLAY MSI X570 is a motherboard that uses the AM4 socket which fits AMD processors.", "/ProductInfoPages/ComponentInfoPages/MotherBoardPage2"),
            new SharkGaming.Products.Components.ComponentTypes.Motherboard.Motherboard("ASRock Z590 Extreme", 1681.73, false, true, "Mid-end", true, 128, "DDR4", 4800, "Motherboard - ATX", "Z590", "LGA 1200", "24-pin main power, 2 x 8 pin ATX12v", "AMI", 4.0, "/Images/Components/Motherboard3.png", "THE ASRock Z590 Extreme is an ATX motherboard that uses the LGA Socket for intels processors.", "/ProductInfoPages/ComponentInfoPages/MotherBoardPage3")
        };

        public static List<SharkGaming.Products.Components.ComponentTypes.Motherboard.Motherboard> GetMockMotherboards()
        {
            return _Motherboard;
        }


    }
}
