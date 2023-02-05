using SharkGaming.Products.Components.ComponentTypes.Storage.Case;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockCaseS
    {
        public static List<Cases> _cases = new List<Cases>()
        {
            new Cases("Shark Gaming Aquarium", 999, true, true, "A case with tempered glass", "MidTower (ATX)", "Black", 10, true, 280, 415, 427, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio", "/Images/Components/Case1.png", "Shark gaming aquarium is a case that allows you to connect to the motherboard and control RGB through the software.", "/ProductInfoPages/ComponentInfoPages/CasePage1"),
            new Cases("Shark Gaming MaelStrom", 599, true, true, "A RGB flow case", "MiniTower (m-ATX)", "Black", 4, true, 210, 405, 425, "ATX", "2xUSB 3.0 & 1x USB 2.0 & HD Audio", "/Images/Components/Case2.png", "This case is the perfect choice for the gamer who is a casual but doesn't want to look like one.", "/ProductInfoPages/ComponentInfoPages/CasePage2"),
            new Cases("Phanteks Enthoo Evolv X Satin Black Kabinet", 1749, true, true, "A case made of aluminium panels and powder coated steel", "MidTower (ATX)", "White", 7, true, 240, 520, 520, "ATX", "1 x USB 3.1 gen 2 Type-C (Needs Front USB-C Supported Motherboard), 2xUSB 3.0, Power button, Microphone, Headphone, D-RGB Mode button, D-RGB Color button", "/Images/Components/Case3.png", "This case is specifically designed to make any casual gamer cry.", "/ProductInfoPages/ComponentInfoPages/CasePage3")

        };

        public static List<Cases> GetMockCases()
        {
            return _cases;
        }
    }
}
