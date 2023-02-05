using SharkGaming.Products.Components.ComponentTypes.Storage;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockSolidStateDrive
    {
        public static List<SolidStateDrive> _SoildSateDrives = new List<SolidStateDrive>
        {
            new SolidStateDrive("Samsung 870 QVO 2.5¨ SSD - 1TB", 618, true, true, "Low power DDR4 SDRAM", 1000, "2.5¨", 560, 530, 11000, 35000, "Quad-niveau celle", "/Images/Components/SSD1.png", "Samsungs EVO870 1 TB delivers a transfer up to 560 mb/sec. The SSD helps you with loading windows and will give you a new gaming experience.", "/ProductInfoPages/ComponentInfoPages/SsdPage1"),
            new SolidStateDrive("Samsung 870 QVO 2.5¨ SSD - 2TB", 1249, true, true, "Low power DDR4 SDRAM", 2000, "2.5¨", 560, 530, 11000, 35000, "Quad-niveau celle", "/Images/Components/SSD2.png", "Samsungs Evo series have taken the world with their amazing transfer speeds. Evo 870 makes your pc read and write faster when its loading.", "/ProductInfoPages/ComponentInfoPages/SsdPage2"),
            new SolidStateDrive("Crucial BX500 1TB 3D NAND 2.5¨", 576, true, true, "Multistep data integrity algorithm", 500, "2.5¨", 540, 500, 8000, 24000, "Sata", "/Images/Components/SSD3.png", "Crucial BX500 1TB 3D NAND 2.5\" is a budget friendly SSD that delivers a solid performance from crucial.", "/ProductInfoPages/ComponentInfoPages/SsdPage3")
        };

        public static List<SolidStateDrive> GetMockSoildSateDrives() { return _SoildSateDrives; }

    }
}
